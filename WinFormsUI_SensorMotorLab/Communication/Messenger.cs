using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class Messenger : IDisposable
    {
        private SerialPort _serialPort;
        private const int START_CODE = 0xFF;
        private const int STOP_CODE = 0xDD;
        private const int BAUD_RATE = 115200;
        private List<byte> buffer = new List<byte>();

        public delegate void MessageReceivedHandler(MessageReceivedEventArgs eventArgs, object sender);
        public event MessageReceivedHandler MessageReceived;
        protected void OnMessageReceived(MessageReceivedEventArgs eventArgs, object sender)
        {
            if (MessageReceived != null)
            {
                MessageReceived(eventArgs, sender);
            }
        }

        public Messenger(string portName)
        {
            _serialPort = new SerialPort(portName, BAUD_RATE);
            _serialPort.Open();
            _serialPort.DataReceived += _serialPort_DataReceived;
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (_serialPort.IsOpen && _serialPort.BytesToRead > 0)
            {
                byte b = (byte)_serialPort.ReadByte();
                if (buffer.Count == 0 && b != START_CODE)
                    continue;
                buffer.Add(b);
                if (b == STOP_CODE)
                {
                    if (buffer[0] != START_CODE)
                    {
                        buffer.Clear();
                        continue;
                    }
                    Message message = new Message();
                    message.MessageType = (MessageType)buffer[1];
                    if (message.MessageType == MessageType.STRING_GET || message.MessageType == MessageType.ERROR_GET)
                    {
                        int length = (int)buffer[2];
                        string payload = Encoding.ASCII.GetString(buffer.GetRange(3, length).ToArray());
                        message.Payload = payload;
                    }
                    else
                    {
                        message.MotorType = (MotorType)buffer[2];
                        message.SensorType = (SensorType)buffer[3];
                        if (message.MessageType == MessageType.ANGLE_GET || message.MessageType == MessageType.SPEED_GET)
                        {
                            message.Payload = BitConverter.ToInt16(buffer.GetRange(4, 2).ToArray(), 0);
                        }
                        else
                        {
                            message.Payload = BitConverter.ToSingle(buffer.GetRange(4, 4).ToArray(), 0);
                        }
                    }
                    buffer.Clear();
                    OnMessageReceived(new MessageReceivedEventArgs(message), this);
                }
            }
        }

        public void Send(Message message)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.WriteByte(START_CODE);
                memoryStream.WriteByte((byte)message.MessageType);
                memoryStream.WriteByte((byte)message.MotorType);
                memoryStream.WriteByte((byte)message.SensorType);
                if (message.MessageType == MessageType.ANGLE_SET || message.MessageType == MessageType.SPEED_SET)
                {
                    memoryStream.Write(BitConverter.GetBytes((short)message.Payload), 0, 2);
                }
                else if (message.MessageType == MessageType.SENSOR_MOTOR_BINDING_SET)
                {
                    memoryStream.Write((byte[])message.Payload, 0, 2);
                }
                memoryStream.WriteByte(STOP_CODE);
                byte[] buf = memoryStream.ToArray();
                _serialPort.Write(buf, 0, buf.Length);
            }
        }

        public void Dispose()
        {
            if (_serialPort != null)
                _serialPort.Dispose();
        }
    }
}
