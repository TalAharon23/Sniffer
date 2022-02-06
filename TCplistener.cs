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

namespace tcpclientlistner
{
    class Program
    {
        static void Main()
        {

            Thread myThread;
            myThread = new Thread(new ThreadStart(RunServer));
            myThread.Start();
        }
        static void RunServer()
        {
            NetworkStream myStream;
            TcpClient client = null;
            BinaryWriter myServerWriter;
            BinaryReader myServerReader;
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                Console.WriteLine("Starting TCP listener...");
                TcpListener listener = new TcpListener(ipAddress, 500);
                int count = 0;
                while (true)
                {
                    listener.Start();
                    Console.WriteLine("Server is listening..");
                    using (client = listener.AcceptTcpClient())
                    {
                        Console.WriteLine("Waiting for a connection...");
                        Console.WriteLine("Connection accepted.");
                        count++;
                        Console.WriteLine("Reading data...");
                        myStream = client.GetStream();

                        Console.WriteLine("Recieved data");
                        myServerWriter = new BinaryWriter(myStream);
                        myServerReader = new BinaryReader(myStream);
                        Console.WriteLine();
                    }
                    client.Close();
                    listener.Stop();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.StackTrace);
                Console.ReadLine();
            }
        }

    }
}