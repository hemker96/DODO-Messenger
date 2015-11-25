using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DODO_Messenger_Server.Network
{
    abstract class NetworkInputHandler_Interface 
    {
        public abstract void run(NetworkStream stream,String msg);
    }
}
