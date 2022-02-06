

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace TCPClient
{
    class Program
    {
        static Sniffer sniffer;
        static SessionWithServer sessionWithServer;


        static void Main(string[] args) 
        {
            sessionWithServer = new SessionWithServer();
            sniffer = new Sniffer();
            Console.Read();
        }
    }
}
