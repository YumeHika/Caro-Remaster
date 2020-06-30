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
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.ChatScreentextBox = new System.Windows.Forms.TextBox();
            this.ServerPorttextBox = new System.Windows.Forms.TextBox();
            this.ServerIPtextBox = new System.Windows.Forms.TextBox();
            this.ClientPorttextBox = new System.Windows.Forms.TextBox();
            this.ClientIPtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.prsCountdown = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Player_Ava_ptb = new System.Windows.Forms.PictureBox();
            this.PlayerName_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBoxAva = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.tmCountdown = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.MessagetextBox);
            this.panel1.Controls.Add(this.ChatScreentextBox);
            this.panel1.Controls.Add(this.ServerPorttextBox);
            this.panel1.Controls.Add(this.ServerIPtextBox);
            this.panel1.Controls.Add(this.ClientPorttextBox);
            this.panel1.Controls.Add(this.ClientIPtextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPost);
            this.panel1.Controls.Add(this.prsCountdown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Player_Ava_ptb);
            this.panel1.Controls.Add(this.PlayerName_txb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(864, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 623);
            this.panel1.TabIndex = 5;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(241, 414);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(81, 43);
            this.SendButton.TabIndex = 23;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(236, 72);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(87, 23);
            this.ConnectButton.TabIndex = 22;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(236, 23);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(83, 23);
            this.StartButton.TabIndex = 21;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.Location = new System.Drawing.Point(3, 414);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(236, 43);
            this.MessagetextBox.TabIndex = 20;
            // 
            // ChatScreentextBox
            // 
            this.ChatScreentextBox.Location = new System.Drawing.Point(3, 101);
            this.ChatScreentextBox.Multiline = true;
            this.ChatScreentextBox.Name = "ChatScreentextBox";
            this.ChatScreentextBox.Size = new System.Drawing.Size(319, 307);
            this.ChatScreentextBox.TabIndex = 19;
            // 
            // ServerPorttextBox
            // 
            this.ServerPorttextBox.Location = new System.Drawing.Point(130, 24);
            this.ServerPorttextBox.Name = "ServerPorttextBox";
            this.ServerPorttextBox.Size = new System.Drawing.Size(100, 22);
            this.ServerPorttextBox.TabIndex = 18;
            // 
            // ServerIPtextBox
            // 
            this.ServerIPtextBox.Location = new System.Drawing.Point(15, 24);
            this.ServerIPtextBox.Name = "ServerIPtextBox";
            this.ServerIPtextBox.Size = new System.Drawing.Size(100, 22);
            this.ServerIPtextBox.TabIndex = 17;
            // 
            // ClientPorttextBox
            // 
            this.ClientPorttextBox.Location = new System.Drawing.Point(130, 73);
            this.ClientPorttextBox.Name = "ClientPorttextBox";
            this.ClientPorttextBox.Size = new System.Drawing.Size(100, 22);
            this.ClientPorttextBox.TabIndex = 16;
            // 
            // ClientIPtextBox
            // 
            this.ClientIPtextBox.Location = new System.Drawing.Point(15, 73);
            this.ClientIPtextBox.Name = "ClientIPtextBox";
            this.ClientIPtextBox.Size = new System.Drawing.Size(100, 22);
            this.ClientIPtextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-159, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Host";
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(-116, 138);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(100, 22);
            this.txtPost.TabIndex = 13;
            this.txtPost.Text = "127.0.0.1";
            // 
            // prsCountdown
            // 
            this.prsCountdown.Location = new System.Drawing.Point(7, 495);
            this.prsCountdown.Margin = new System.Windows.Forms.Padding(4);
            this.prsCountdown.Name = "prsCountdown";
            this.prsCountdown.Size = new System.Drawing.Size(312, 28);
            this.prsCountdown.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 527);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lượt chơi của";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Player_Ava_ptb
            // 
            this.Player_Ava_ptb.Location = new System.Drawing.Point(243, 527);
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
            this.PlayerName_txb.Location = new System.Drawing.Point(0, 562);
            this.PlayerName_txb.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerName_txb.Name = "PlayerName_txb";
            this.PlayerName_txb.Size = new System.Drawing.Size(239, 37);
            this.PlayerName_txb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 460);
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
            this.label1.Location = new System.Drawing.Point(9, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian còn: ";
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
            this.pnlChessBoard.Location = new System.Drawing.Point(165, 3);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(691, 639);
            this.pnlChessBoard.TabIndex = 3;
            // 
            // tmCountdown
            // 
            this.tmCountdown.Tick += new System.EventHandler(this.tmCountdown_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Client";
            // 
            // Battle_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 647);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBoxAva;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Timer tmCountdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.TextBox ChatScreentextBox;
        private System.Windows.Forms.TextBox ServerPorttextBox;
        private System.Windows.Forms.TextBox ServerIPtextBox;
        private System.Windows.Forms.TextBox ClientPorttextBox;
        private System.Windows.Forms.TextBox ClientIPtextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}

