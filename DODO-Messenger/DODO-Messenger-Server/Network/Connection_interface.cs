using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DODO_Messenger_Server.Network
{
    abstract class Connection_interface
    {
        public abstract void ClientBinder();
        public abstract void send(String toSend);
    }
}
