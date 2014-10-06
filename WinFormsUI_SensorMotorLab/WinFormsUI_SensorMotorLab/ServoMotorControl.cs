using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communication;

using Message = Communication.Message;

namespace WinFormsUI_SensorMotorLab
{
    public partial class ServoMotorControl : UserControl, IMessageHandler
    {
        public MotorType MotorType
        {
            get { return MotorType.RC_SERVO_MOTOR; }
        }

        public Messenger Messenger { get; set; }

        public void HandleMessage(Message message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<Message>(HandleMessage), message);
            }
            else
            {
                if (message.MessageType == MessageType.ALL_STOP)
                {
                    _radioButtonManual.Checked = true;
                    updateControlSource();
                }
                else if (message.MotorType == MotorType && message.MessageType == MessageType.ANGLE_GET)
                {
                    _textBoxAngle.Text = ((short)message.Payload).ToString();
                }
            }
        }

        private SensorType sensorType
        {
            get
            {
                return Namer.SensorTypeFromLongName((string)_comboBoxSensor.SelectedItem);
            }
        }

        private MotorFunction motorFunction
        {
            get
            {
                return MotorFunction.ANGLE;
            }
        }

        private Direction direction
        {
            get
            {
                if (_radioButtonCCW.Checked)
                {
                    return Direction.CCW;
                }
                return Direction.CW;
            }
        }

        public ServoMotorControl()
        {
            InitializeComponent();
            _radioButtonManual.Checked = true;
            updateControlSource();

            _labelName.Text = Namer.ToLongName(MotorType);

            foreach (SensorType sensorType in Enum.GetValues(typeof(SensorType)))
            {
                _comboBoxSensor.Items.Add(Namer.ToLongName(sensorType));
            }
        }

        private void _radioButtonManual_CheckedChanged(object sender, EventArgs e)
        {
            updateControlSource();
        }

        private void updateControlSource()
        {
            if (_radioButtonManual.Checked)
            {
                foreach (Control control in _groupBoxManual.Controls)
                {
                    control.Enabled = true;
                }
                foreach (Control control in _groupBoxSensor.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in _groupBoxManual.Controls)
                {
                    control.Enabled = false;
                }
                foreach (Control control in _groupBoxSensor.Controls)
                {
                    control.Enabled = true;
                }
            }
        }

        private void _radioButtonSensor_CheckedChanged(object sender, EventArgs e)
        {
            updateControlSource();
        }

        private void _buttonAngleSet_Click(object sender, EventArgs e)
        {
            short angle;
            if (short.TryParse(_textBoxSetAngle.Text, out angle))
            {
                Message message =
                    new Message
                    {
                        MessageType = MessageType.ANGLE_SET,
                        MotorType = MotorType,
                        Payload = angle
                    };
                Messenger.Send(message);
            }
        }

        private void _buttonSensorControlSet_Click(object sender, EventArgs e)
        {
            Message message =
                new Message
                {
                    MessageType = MessageType.SENSOR_MOTOR_BINDING_SET,
                    MotorType = MotorType,
                    SensorType = sensorType,
                    Payload = new byte[] { (byte)motorFunction, (byte)direction }
                };
            Messenger.Send(message);
        }
    }
}
