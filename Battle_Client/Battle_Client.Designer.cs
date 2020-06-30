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
            this.prsCountdown = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Player_Ava_ptb = new System.Windows.Forms.PictureBox();
            this.PlayerName_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pctBoxAva = new System.Windows.Forms.PictureBox();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.tmCountdown = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Ava_ptb)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.prsCountdown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Player_Ava_ptb);
            this.panel1.Controls.Add(this.PlayerName_txb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SendButton);
            this.panel1.Location = new System.Drawing.Point(864, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 631);
            this.panel1.TabIndex = 5;
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
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(246, 416);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(73, 41);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.btnSend_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect to Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 27);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 74);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(312, 336);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 416);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 41);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Enter your chat name:";
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
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pctBoxAva;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Timer tmCountdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}

