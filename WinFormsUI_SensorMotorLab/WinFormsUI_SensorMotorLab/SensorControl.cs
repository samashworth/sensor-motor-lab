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
    public partial class SensorControl : UserControl, IMessageHandler
    {
        private Messenger _messenger;
        private SensorType _sensorType;

        public SensorControl()
        {
            InitializeComponent();
        }

        public Messenger Messenger
        {
            get { return _messenger; }
            set { _messenger = value; }
        }

        public SensorType SensorType
        {
            get { return _sensorType; }
            set
            {
                _sensorType = value;
                _labelName.Text = Namer.ToLongName(_sensorType);
            }
        }

        public string Units
        {
            get
            {
                return _labelUnits.Text;
            }
            set
            {
                _labelUnits.Text = value;
            }
        }

        public void HandleMessage(Message message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<Message>(HandleMessage), message);
            }
            else
            {
                if (message.MessageType == MessageType.READING_GET &&
                    message.SensorType == _sensorType)
                {
                    _textBoxReading.Text = ((float)message.Payload).ToString();
                }
            }
        }
    }
}
