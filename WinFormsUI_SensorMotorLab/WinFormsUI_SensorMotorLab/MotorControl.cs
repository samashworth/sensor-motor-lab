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
    public partial class MotorControl : UserControl, IMessageHandler
    {
        private MotorType _motorType;
        public MotorType MotorType
        {
            get { return _motorType; }
            set
            {
                _motorType = value;
                _labelName.Text = Namer.ToLongName(_motorType);
            }
        }

        public Messenger Messenger { get; set; }

        public void HandleMessage(Message message)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<Message>(HandleMessage), message);
            }
            else
            {
                if (message.MessageType == MessageType.ALL_STOP)
                {
                    _radioButtonManual.Checked = true;
                    updateControlSource();
                }
                else if (message.MotorType == _motorType && message.MessageType == MessageType.SPEED_GET)
                {
                    _textBoxSpeed.Text = ((short)message.Payload).ToString();
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
                if (_radioButtonSpeed.Checked)
                {
                    return MotorFunction.SPEED;
                }
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

        public MotorControl()
        {
            InitializeComponent();
            _radioButtonManual.Checked = true;
            updateControlSource();

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

        private void _buttonSpeedSet_Click(object sender, EventArgs e)
        {
            _textBoxSetAngle.Text = "";
            short speed;
            if (short.TryParse(_textBoxSetSpeed.Text, out speed))
            {
                Message message =
                    new Message
                    {
                        MessageType = MessageType.SPEED_SET,
                        MotorType = _motorType,
                        Payload = speed
                    };
                Messenger.Send(message);
            }
        }

        private void _buttonAngleSet_Click(object sender, EventArgs e)
        {
            _textBoxSetSpeed.Text = "";
            short angle;
            if (short.TryParse(_textBoxSetAngle.Text, out angle))
            {
                Message message =
                    new Message
                    {
                        MessageType = MessageType.ANGLE_SET,
                        MotorType = _motorType,
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
                    MotorType = _motorType,
                    SensorType = sensorType,
                    Payload = new byte[] { (byte)motorFunction, (byte)direction }
                };
            Messenger.Send(message);
        }
    }
}
