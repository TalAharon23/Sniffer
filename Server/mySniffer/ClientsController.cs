using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Drawing;

namespace Server
{
    class ClientsController
    {
        private const int PORT = 4000;
        private MainForm mainForm;
        Thread myThread;
        List<ClientHandler> clientHandlerList = new List<ClientHandler>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public ClientsController(MainForm mainForm) //פעולה הבונה אשר מצהירה על ת'ריד חדש העוזר להריץ מספר דברים בו זמנית

        {
            // TODO: Complete member initialization
            this.mainForm = mainForm;
            myThread = new Thread(new ThreadStart(RunServer));
            myThread.Start();
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void RunServer() //מתחילה את האזנה לקליאנטים, כאשר לקוח התקבל מעבירה הפונקציה את האייפי לפעולה המוסיפה אותה לרשימה
        {
           // NetworkStream myStream;
            TcpClient client = null;
           // BinaryWriter myServerWriter;
           // BinaryReader myServerReader;
            try
            {
                this.mainForm.PrintLog("Starting TCP listener...Waiting for a connection...", Color.Black);
                TcpListener listener = new TcpListener(PORT);
                listener.Start();
                while (true)
                {
                    using (client = listener.AcceptTcpClient())
                    {
                        string clientIP = (client.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
                        this.mainForm.PrintLog("Connection accepted  IP = " + clientIP, Color.Black);
                        this.mainForm.AddIp(clientIP);
                        clientHandlerList.Add(new ClientHandler(client, mainForm));
                    }
                }
                listener.Stop();
            }
            catch (Exception e)
            {
                this.mainForm.PrintLog("Error: " + e.StackTrace, Color.Red);
            }
        }

    }
}
