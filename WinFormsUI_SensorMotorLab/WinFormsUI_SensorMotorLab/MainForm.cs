using Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Communication.Message;

namespace WinFormsUI_SensorMotorLab
{
    public partial class MainForm : Form
    {
        private Messenger _messenger;
        List<IMessageHandler> _messageHandlerList = new List<IMessageHandler>();
        private bool _isConnected = false;

        public MainForm()
        {
            InitializeComponent();

            string comPortName = ConfigurationManager.AppSettings["COMPortName"];
            foreach (var portName in SerialPort.GetPortNames())
            {
                int index = _comboBoxPorts.Items.Add(portName);
                if (portName == comPortName)
                {
                    _comboBoxPorts.SelectedIndex = index;
                }
            }
            _labelConnectionStatus.Text = "Disconnected";

            _tabControlMotor.Enabled = false;
            _tabControlSensor.Enabled = false;
        }

        void _messenger_MessageReceived(MessageReceivedEventArgs eventArgs, object sender)
        {
            Message message = eventArgs.Message;
            foreach (IMessageHandler messageHandler in _messageHandlerList)
            {
                messageHandler.HandleMessage(message);
            }
        }

        IEnumerable<Control> getControlsDeep(Control root)
        {
            yield return root;
            if (root.Controls.Count > 0)
            {
                foreach (Control control in root.Controls)
                {
                    foreach (Control subControl in getControlsDeep(control))
                    {
                        yield return subControl;
                    }
                }
            }
        }

        private void _buttonConnect_Click(object sender, EventArgs e)
        {
            if (!_isConnected && _comboBoxPorts.SelectedIndex >= 0)
            {
                string comPortName = (string)_comboBoxPorts.SelectedItem;
                try
                {
                    _messenger = new Messenger(comPortName);

                    _motorControlDC.MotorType = MotorType.DC_MOTOR;
                    _motorControlStepper.MotorType = MotorType.STEPPER_MOTOR;
                    _motorControlDummy.MotorType = MotorType.DUMMY_MOTOR;

                    foreach (Control control in getControlsDeep(this))
                    {
                        if (control is IMessageHandler)
                        {
                            _messageHandlerList.Add((IMessageHandler)control);
                        }
                    }

                    foreach (IMessageHandler messageHandler in _messageHandlerList)
                    {
                        messageHandler.Messenger = _messenger;
                    }
                    _labelConnectionStatus.Text = "Connected";
                    _buttonConnect.Text = "Disconnect";
                    _messenger.MessageReceived += _messenger_MessageReceived;

                    _tabControlMotor.Enabled = true;
                    _tabControlSensor.Enabled = true;
                    _isConnected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Attempt to connect to " + comPortName + " failed." + Environment.NewLine + ex.Message, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_isConnected)
            {
                _messenger.MessageReceived -= _messenger_MessageReceived;
                _messenger.Dispose();
                _messenger = null;
                _buttonConnect.Text = "Connect";
                _labelConnectionStatus.Text = "Disconnected";
                _tabControlMotor.Enabled = false;
                _tabControlSensor.Enabled = false;
                _isConnected = false;
            }
        }

        private void _buttonRefresh_Click(object sender, EventArgs e)
        {
            _comboBoxPorts.Items.Clear();
            string comPortName = ConfigurationManager.AppSettings["COMPortName"];
            foreach (var portName in SerialPort.GetPortNames())
            {
                int index = _comboBoxPorts.Items.Add(portName);
                if (portName == comPortName)
                {
                    _comboBoxPorts.SelectedIndex = index;
                }
            }
        }
    }
}
