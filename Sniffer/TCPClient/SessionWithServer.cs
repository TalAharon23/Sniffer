using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace TCPClient
{
    class SessionWithServer
    {
        private const int PORT = 4000;
        private const string HOST = "192.168.2.63";
        static NetworkStream myStream;
        static BinaryWriter myClientWriter;
        static BinaryReader myClientReader;
        static TcpClient client;
        static Thread  runTread;

        public SessionWithServer()
        {
            runTread = new Thread(new ThreadStart(Run));
            runTread.Start();
        }

        private static void Run()
        {
            client = new TcpClient();
            while (true)
            {
                try
                {
                    client.Connect(HOST, PORT);
                    myStream = client.GetStream();
                    myClientWriter = new BinaryWriter(myStream);
                    myClientReader = new BinaryReader(myStream);
                    break;
                }
                catch (SocketException ske)
                {
                    continue;
                }
            }

            Console.WriteLine("Connection Established");
        }

        public static void Send(byte[] buf)
        {
            try
            {
                if (myClientWriter != null)
                    myClientWriter.Write(buf);
            }
            catch (SocketException ske) { }
        }
    }
}
