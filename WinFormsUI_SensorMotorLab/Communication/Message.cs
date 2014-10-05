using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class Message
    {
        public MessageType MessageType { get; set; }
        public MotorType MotorType { get; set; }
        public SensorType SensorType { get; set; }
        public int? Length { get; set; }
        public object Payload { get; set; }

        public override string ToString()
        {
            if (MessageType == MessageType.ERROR_GET)
            {
                return string.Format("{0}\t{1}", MessageType, (string)Payload);
            }
            else if (MessageType == MessageType.STRING_GET)
            {
                string payload = (string)Payload;
                return string.Format("{0}\t{1}", MessageType, (string)Payload);
            }
            else if (MessageType == MessageType.ANGLE_GET || MessageType == MessageType.SPEED_GET)
            {
                return string.Format("{0}\t{1}\t{2}", MessageType, MotorType, (short)Payload);
            }
            else if (MessageType == MessageType.READING_GET)
            {
                return string.Format("{0}\t{1}\t{2}", MessageType, SensorType, (float)Payload);
            }
            return "";
        }
    }
}
