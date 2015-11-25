using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DODO_Messenger_Server.Network
{
    class StandartInputHandler : NetworkInputHandler_Interface
    {
        public override void run(NetworkStream stream, string msg)
        {
            MessageBuilder M = new MessageBuilder();
            String[] inp = M.DeBuild(msg);

            //Handle

            String outp = M.Build(null);
            Byte[] sendBytes = Encoding.ASCII.GetBytes(outp);
            stream.Write(sendBytes, 0, sendBytes.Length);
            stream.Flush();
            Console.WriteLine(" >> " + outp);

        }
    }
}
