namespace Server
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.comboBoxClientsIP = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.richTextBoxData);
            this.groupBox1.Controls.Add(this.richTextBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(304, 27);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(455, 344);
            this.treeView1.TabIndex = 2;
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBoxData.Location = new System.Drawing.Point(292, 15);
            this.richTextBoxData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(477, 370);
            this.richTextBoxData.TabIndex = 1;
            this.richTextBoxData.Text = "";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxLog.Location = new System.Drawing.Point(3, 15);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(286, 370);
            this.richTextBoxLog.TabIndex = 0;
            this.richTextBoxLog.Text = "";
            // 
            // comboBoxClientsIP
            // 
            this.comboBoxClientsIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientsIP.FormattingEnabled = true;
            this.comboBoxClientsIP.Location = new System.Drawing.Point(70, 11);
            this.comboBoxClientsIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClientsIP.Name = "comboBoxClientsIP";
            this.comboBoxClientsIP.Size = new System.Drawing.Size(128, 21);
            this.comboBoxClientsIP.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 444);
            this.Controls.Add(this.comboBoxClientsIP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Server";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.ComboBox comboBoxClientsIP;
        private System.Windows.Forms.TreeView treeView1;
    }
}

