using Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI_SensorMotorLab
{
    public interface IMessageHandler
    {
        Messenger Messenger { get; set; }
        void HandleMessage(Message message);
    }
}
