namespace Battle_Client
{
    partial class Battle_Client
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prsCountdown = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Player_Ava_ptb = new System.Windows.Forms.PictureBox();
            this.PlayerName_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBoxAva = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.tmCountdown = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.prsCountdown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Player_Ava_ptb);
            this.panel1.Controls.Add(this.PlayerName_txb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(864, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 631);
            this.panel1.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(239, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 51);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(0, 351);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(232, 42);
            this.txtMessage.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(0, 66);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(316, 279);
            this.txtStatus.TabIndex = 11;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(50, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(177, 22);
            this.txtPort.TabIndex = 10;
            this.txtPort.Text = "8910";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(49, 11);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(178, 22);
            this.txtHost.TabIndex = 9;
            this.txtHost.Text = "127.0.0.1";
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Host";
            // 
            // prsCountdown
            // 
            this.prsCountdown.Location = new System.Drawing.Point(4, 431);
            this.prsCountdown.Margin = new System.Windows.Forms.Padding(4);
            this.prsCountdown.Name = "prsCountdown";
            this.prsCountdown.Size = new System.Drawing.Size(312, 28);
            this.prsCountdown.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lượt chơi của";
            // 
            // Player_Ava_ptb
            // 
            this.Player_Ava_ptb.Location = new System.Drawing.Point(235, 467);
            this.Player_Ava_ptb.Margin = new System.Windows.Forms.Padding(4);
            this.Player_Ava_ptb.Name = "Player_Ava_ptb";
            this.Player_Ava_ptb.Size = new System.Drawing.Size(80, 74);
            this.Player_Ava_ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_Ava_ptb.TabIndex = 4;
            this.Player_Ava_ptb.TabStop = false;
            // 
            // PlayerName_txb
            // 
            this.PlayerName_txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName_txb.Location = new System.Drawing.Point(10, 504);
            this.PlayerName_txb.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerName_txb.Name = "PlayerName_txb";
            this.PlayerName_txb.Size = new System.Drawing.Size(217, 37);
            this.PlayerName_txb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 396);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian còn: ";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(243, 351);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 41);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pctBoxAva);
            this.flowLayoutPanel1.Controls.Add(this.MenuBtn);
            this.flowLayoutPanel1.Controls.Add(this.NewGameBtn);
            this.flowLayoutPanel1.Controls.Add(this.QuitBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 11);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 631);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pctBoxAva
            // 
            this.pctBoxAva.Image = global::Battle_Client.Properties.Resources.Logo_Caro;
            this.pctBoxAva.Location = new System.Drawing.Point(4, 4);
            this.pctBoxAva.Margin = new System.Windows.Forms.Padding(4);
            this.pctBoxAva.Name = "pctBoxAva";
            this.pctBoxAva.Size = new System.Drawing.Size(133, 123);
            this.pctBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAva.TabIndex = 0;
            this.pctBoxAva.TabStop = false;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Location = new System.Drawing.Point(4, 135);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(132, 54);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.Text = "MENU";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(4, 197);
            this.NewGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(132, 54);
            this.NewGameBtn.TabIndex = 1;
            this.NewGameBtn.Text = "NEW GAME";
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(4, 259);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(132, 54);
            this.QuitBtn.TabIndex = 2;
            this.QuitBtn.Text = "QUIT";
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(165, 11);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(691, 631);
            this.pnlChessBoard.TabIndex = 3;
            // 
            // tmCountdown
            // 
            this.tmCountdown.Tick += new System.EventHandler(this.tmCountdown_Tick);
            // 
            // Battle_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlChessBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Battle_Client";
            this.Text = "Batte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battle_FormClosing);
            this.Load += new System.EventHandler(this.Battle_Client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prsCountdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Player_Ava_ptb;
        private System.Windows.Forms.TextBox PlayerName_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBoxAva;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Timer tmCountdown;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConnect;
    }
}

