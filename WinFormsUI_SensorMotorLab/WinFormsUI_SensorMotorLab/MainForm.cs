using Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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

        public MainForm()
        {
            InitializeComponent();
            
            string comPortName = ConfigurationManager.AppSettings["COMPortName"];
            _messenger = new Messenger(comPortName);
            _messenger.MessageReceived += _messenger_MessageReceived;
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
    }
}
