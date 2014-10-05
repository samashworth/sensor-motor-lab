using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public Message Message { get; set; }

        public MessageReceivedEventArgs(Message message)
        {
            Message = message;
        }
    }
}
