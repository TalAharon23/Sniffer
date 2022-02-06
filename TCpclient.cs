using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace tcpclientclient
{
    class Program
    {
        static void Main(string[] args)
        {
            runC();
        }
        static void runC()
        {
            NetworkStream myStream;
            TcpClient client = null;
            BinaryWriter myClientWriter;
            BinaryReader myClientReader;
            client = new TcpClient();
            client.Connect("localhost", 500);
            myStream = client.GetStream();
            if (myStream.CanWrite && myStream.CanRead)
                Console.WriteLine("FFF");
            myClientWriter = new BinaryWriter(myStream);
            myClientReader = new BinaryReader(myStream);
            Console.WriteLine("Connection Established");

        }
    }
}
