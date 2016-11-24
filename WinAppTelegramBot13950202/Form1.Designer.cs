namespace WinAppTelegramBot13950202
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelegramField = new System.Windows.Forms.TextBox();
            this.lblLastMsgId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMsgWelcomePlease = new System.Windows.Forms.TextBox();
            this.btnGetNewinLast5SecondsinList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestToken = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContacts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSharePointServer = new System.Windows.Forms.TextBox();
            this.lblSharePoint = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblBotToken = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerSharePoint = new System.Windows.Forms.Timer(this.components);
            this.timerRecieveMessageTelegramBot = new System.Windows.Forms.Timer(this.components);
            this.lblSaved = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMsgPassw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMsgPassw);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTelegramField);
            this.groupBox1.Controls.Add(this.lblLastMsgId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMsgWelcomePlease);
            this.groupBox1.Controls.Add(this.btnGetNewinLast5SecondsinList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Controls.Add(this.txtAdminID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTestToken);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtContacts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTargetList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSharePointServer);
            this.groupBox1.Controls.Add(this.lblSharePoint);
            this.groupBox1.Controls.Add(this.txtToken);
            this.groupBox1.Controls.Add(this.lblBotToken);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(750, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alert me";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 473);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "TelegramField";
            // 
            // txtTelegramField
            // 
            this.txtTelegramField.Location = new System.Drawing.Point(239, 470);
            this.txtTelegramField.Name = "txtTelegramField";
            this.txtTelegramField.Size = new System.Drawing.Size(129, 38);
            this.txtTelegramField.TabIndex = 21;
            this.txtTelegramField.Text = "telegram";
            this.txtTelegramField.TextChanged += new System.EventHandler(this.txtTelegramField_TextChanged);
            // 
            // lblLastMsgId
            // 
            this.lblLastMsgId.AutoSize = true;
            this.lblLastMsgId.Location = new System.Drawing.Point(695, 492);
            this.lblLastMsgId.Name = "lblLastMsgId";
            this.lblLastMsgId.Size = new System.Drawing.Size(44, 31);
            this.lblLastMsgId.TabIndex = 20;
            this.lblLastMsgId.Text = "51";
            this.lblLastMsgId.TextChanged += new System.EventHandler(this.lblLastMsgId_TextChanged);
            this.lblLastMsgId.Click += new System.EventHandler(this.lblLastMsgId_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Welcome msg";
            // 
            // txtMsgWelcomePlease
            // 
            this.txtMsgWelcomePlease.Location = new System.Drawing.Point(240, 361);
            this.txtMsgWelcomePlease.Name = "txtMsgWelcomePlease";
            this.txtMsgWelcomePlease.Size = new System.Drawing.Size(482, 38);
            this.txtMsgWelcomePlease.TabIndex = 18;
            this.txtMsgWelcomePlease.Text = "Welcome, please give me username and password";
            this.txtMsgWelcomePlease.TextChanged += new System.EventHandler(this.txtMsgWelcomePlease_TextChanged);
            // 
            // btnGetNewinLast5SecondsinList
            // 
            this.btnGetNewinLast5SecondsinList.Location = new System.Drawing.Point(551, 301);
            this.btnGetNewinLast5SecondsinList.Name = "btnGetNewinLast5SecondsinList";
            this.btnGetNewinLast5SecondsinList.Size = new System.Drawing.Size(143, 50);
            this.btnGetNewinLast5SecondsinList.TabIndex = 17;
            this.btnGetNewinLast5SecondsinList.Text = "button1";
            this.btnGetNewinLast5SecondsinList.UseVisualStyleBackColor = true;
            this.btnGetNewinLast5SecondsinList.Click += new System.EventHandler(this.btnGetNewinLast5SecondsinList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "Log Location";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(225, 308);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(238, 38);
            this.txtLog.TabIndex = 15;
            this.txtLog.Text = "c:\\logs\\";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(306, 256);
            this.txtAdminID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(157, 38);
            this.txtAdminID.TabIndex = 14;
            this.txtAdminID.Text = "151370482";
            this.txtAdminID.TextChanged += new System.EventHandler(this.txtAdminID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admin Telegram ID";
            // 
            // btnTestToken
            // 
            this.btnTestToken.Location = new System.Drawing.Point(658, 48);
            this.btnTestToken.Name = "btnTestToken";
            this.btnTestToken.Size = new System.Drawing.Size(81, 42);
            this.btnTestToken.TabIndex = 12;
            this.btnTestToken.Text = "test";
            this.btnTestToken.UseVisualStyleBackColor = true;
            this.btnTestToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seconds";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(525, 152);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtInterval.MaxLength = 1;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(33, 38);
            this.txtInterval.TabIndex = 10;
            this.txtInterval.Text = "5";
            this.txtInterval.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInterval_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Interval";
            // 
            // txtContacts
            // 
            this.txtContacts.Location = new System.Drawing.Point(232, 204);
            this.txtContacts.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtContacts.Name = "txtContacts";
            this.txtContacts.Size = new System.Drawing.Size(231, 38);
            this.txtContacts.TabIndex = 8;
            this.txtContacts.Text = "Contacts";
            this.txtContacts.TextChanged += new System.EventHandler(this.txtContacts_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "List Contacts";
            // 
            // txtTargetList
            // 
            this.txtTargetList.Location = new System.Drawing.Point(179, 152);
            this.txtTargetList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTargetList.Name = "txtTargetList";
            this.txtTargetList.Size = new System.Drawing.Size(210, 38);
            this.txtTargetList.TabIndex = 6;
            this.txtTargetList.Text = "ticketing";
            this.txtTargetList.TextChanged += new System.EventHandler(this.txtTargetList_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "List Alert";
            // 
            // txtSharePointServer
            // 
            this.txtSharePointServer.Location = new System.Drawing.Point(207, 100);
            this.txtSharePointServer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSharePointServer.Name = "txtSharePointServer";
            this.txtSharePointServer.Size = new System.Drawing.Size(501, 38);
            this.txtSharePointServer.TabIndex = 4;
            this.txtSharePointServer.Text = "http://srv-shptest";
            this.txtSharePointServer.TextChanged += new System.EventHandler(this.txtSharePointServer_TextChanged);
            // 
            // lblSharePoint
            // 
            this.lblSharePoint.AutoSize = true;
            this.lblSharePoint.Location = new System.Drawing.Point(45, 103);
            this.lblSharePoint.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSharePoint.Name = "lblSharePoint";
            this.lblSharePoint.Size = new System.Drawing.Size(148, 31);
            this.lblSharePoint.TabIndex = 3;
            this.lblSharePoint.Text = "SharePoint";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(145, 48);
            this.txtToken.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(502, 38);
            this.txtToken.TabIndex = 2;
            this.txtToken.Text = "287401999:AAG_D0e0k1MHTAt8JhK9UPYPfZkGTKBzyeE";
            this.txtToken.TextChanged += new System.EventHandler(this.txtToken_TextChanged);
            // 
            // lblBotToken
            // 
            this.lblBotToken.AutoSize = true;
            this.lblBotToken.Location = new System.Drawing.Point(45, 51);
            this.lblBotToken.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblBotToken.Name = "lblBotToken";
            this.lblBotToken.Size = new System.Drawing.Size(90, 31);
            this.lblBotToken.TabIndex = 1;
            this.lblBotToken.Text = "Token";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 47);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(778, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(194, 511);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Log";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timerSharePoint
            // 
            this.timerSharePoint.Interval = 5500;
            this.timerSharePoint.Tick += new System.EventHandler(this.timerSharePoint_Tick);
            // 
            // timerRecieveMessageTelegramBot
            // 
            this.timerRecieveMessageTelegramBot.Enabled = true;
            this.timerRecieveMessageTelegramBot.Interval = 6000;
            this.timerRecieveMessageTelegramBot.Tick += new System.EventHandler(this.timerRecieveMessageTelegramBot_Tick);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.ForeColor = System.Drawing.Color.Red;
            this.lblSaved.Location = new System.Drawing.Point(779, 2);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(0, 31);
            this.lblSaved.TabIndex = 2;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 417);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "pass req";
            // 
            // txtMsgPassw
            // 
            this.txtMsgPassw.Location = new System.Drawing.Point(240, 414);
            this.txtMsgPassw.Name = "txtMsgPassw";
            this.txtMsgPassw.Size = new System.Drawing.Size(482, 38);
            this.txtMsgPassw.TabIndex = 23;
            this.txtMsgPassw.Text = "Please give me password /passw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 473);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 31);
            this.label10.TabIndex = 26;
            this.label10.Text = "UsernameField";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 470);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 38);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "uname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Alert me for Telegram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblBotToken;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContacts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSharePointServer;
        private System.Windows.Forms.Label lblSharePoint;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTestToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerSharePoint;
        private System.Windows.Forms.Timer timerRecieveMessageTelegramBot;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetNewinLast5SecondsinList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMsgWelcomePlease;
        private System.Windows.Forms.Label lblLastMsgId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelegramField;
        private System.Windows.Forms.Label lblSaved;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMsgPassw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

