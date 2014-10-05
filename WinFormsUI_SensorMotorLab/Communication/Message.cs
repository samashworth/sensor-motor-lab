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
    }
}
