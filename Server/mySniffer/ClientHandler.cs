using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Drawing;

namespace Server
{
    class ClientHandler
    {
        private TcpClient client;
        private MainForm mainForm;
        NetworkStream myStream;
        BinaryWriter myServerWriter;
        BinaryReader myServerReader;

        public ClientHandler(TcpClient client, MainForm mainForm) //פעולה בונה וגם מקבלת את הפאקטים ובאמצעות ספליט מחלקת אותם ושולחת אותם לטופס הראשי
        {
            // TODO: Complete member initialization
            this.client = client;
            this.mainForm = mainForm;


            Console.WriteLine("Reading data...");
            myStream = client.GetStream();

            Console.WriteLine("Recieved data");
            myServerWriter = new BinaryWriter(myStream);
            myServerReader = new BinaryReader(myStream);
            try
            {
                byte[] buf = new byte[20000];
                while (true)
                {
                    if (client.Client.Connected)
                    {
                        int rec = client.Client.Receive(buf, 0, buf.Length, SocketFlags.None);
                        string data = Encoding.ASCII.GetString(buf).Substring(0, rec);
                        string[] items = data.Split('#');
                        if (items[0].Equals("Packet"))
                        {
                            string[] fields = items[1].Split('$');
                            mainForm.AddNode(fields); 
                        }
                    }
                }
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            client.Close();
        }
    }
}