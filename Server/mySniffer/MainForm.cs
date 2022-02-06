using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Server
{
    public enum Protocol
    {
        TCP = 6,
        UDP = 17,
        Unknown = -1
    };
    public partial class MainForm : Form
    {
        ClientsController clientsController;
      
        public MainForm()
        {
            InitializeComponent();
            clientsController = new ClientsController(this);
        }


        public void AddNode(string[] fields) //הכנסת המידע של כל פאקט ע"י מיון לפי סוגה והצגת המידע באמצעות עץ – treeview1
        {
            this.Invoke((MethodInvoker)delegate
            {
                string[] ar = { fields[10], fields[11], fields[8], fields[12], fields[13] };
                treeView1.BeginUpdate();
                treeView1.Nodes.Add("Packet " + treeView1.Nodes.Count);
                TreeNode parent = treeView1.Nodes[treeView1.Nodes.Count-1];
                TreeNode ipNode = parent.Nodes.Add("IP"); 
                for (int i = 0; i <=11; i++)
                    ipNode.Nodes.Add(fields[i]);

                TreeNode transportNode = parent.Nodes.Add(fields[8]);
                int count = fields[8].Equals("UDP") ? 4 : 7;
                for (int i = 12; i < 12 + count; i++)
                    transportNode.Nodes.Add(fields[i]);
                treeView1.EndUpdate();
                treeView1.Nodes[treeView1.Nodes.Count - 1].EnsureVisible();
            });
        }


         public void PrintLog(string msg, Color color) //מוסיפה הודעה חדשה לתוך חלון ה info
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.richTextBoxLog.SelectionColor = color;
                this.richTextBoxLog.AppendText(msg + Environment.NewLine);
                this.richTextBoxLog.ScrollToCaret();
            });
        }
         public void AddIp(string ip) //הוספת אייפי חדש לתוך הComboBox 
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.comboBoxClientsIP.Items.Add(ip);
                this.comboBoxClientsIP.SelectedIndex = 0;
            });
        }

       
    }
}
