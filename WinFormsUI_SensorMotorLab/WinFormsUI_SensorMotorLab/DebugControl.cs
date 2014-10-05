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
    public partial class DebugControl : UserControl, IMessageHandler
    {
        private Messenger _messenger;
        private const int MAX_ROWS = 1000;
        private object _dataGridViewLock = new object();

        public DebugControl()
        {
            InitializeComponent();
        }

        public Messenger Messenger
        {
            get { return _messenger; }
            set { _messenger = value; }
        }

        public void HandleMessage(Message message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<Message>(HandleMessage), message);
            }
            else
            {
                if (_checkBoxDebugOn.Checked)
                {
                    bool add = true;
                    if (message.MessageType == MessageType.STRING_GET &&
                        !_checkBoxStringGet.Checked)
                    {
                        add = false;
                    }
                    else if (message.MessageType == MessageType.READING_GET &&
                        !_checkBoxReadingGet.Checked)
                    {
                        add = false;
                    }
                    else if (message.MessageType == MessageType.SPEED_GET &&
                        !_checkBoxSpeedGet.Checked)
                    {
                        add = false;
                    }
                    else if (message.MessageType == MessageType.ANGLE_GET &&
                        !_checkBoxAngleGet.Checked)
                    {
                        add = false;
                    }

                    if (add)
                    {
                        string data = message.ToString().Replace(message.MessageType.ToString() + "\t", "");
                        data = data.Replace("\t", "    ");
                        _dataGridView.Rows.Add(message.MessageType, data);
                        if (_dataGridView.Rows.Count > MAX_ROWS)
                        {
                            lock (_dataGridViewLock)
                            {
                                if (_dataGridView.Rows.Count > MAX_ROWS)
                                {
                                    int toRemove = _dataGridView.Rows.Count - MAX_ROWS;
                                    for (int i = 0; i < toRemove; i++)
                                    {
                                        _dataGridView.Rows.RemoveAt(0);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void _checkBoxDebugOn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void _buttonClear_Click(object sender, EventArgs e)
        {
            _dataGridView.Rows.Clear();
        }
    }
}
