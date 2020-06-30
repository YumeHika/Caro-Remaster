using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Net.Configuration;
using SimpleTCP;

namespace Battle_Client
{
  

    public partial class Battle_Client : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;


        #region Properties
        Chess_Board_Manager ChessBoard;
        #endregion

        public Battle_Client()
        {

            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ServerIPtextBox.Text = address.ToString();
                }
            }

            ChessBoard = new Chess_Board_Manager(pnlChessBoard, PlayerName_txb, Player_Ava_ptb);
            ChessBoard.Ended_Game += ChessBoard_Ended_Game; ;
            ChessBoard.Player_Marked += ChessBoard_Player_Marked;

            prsCountdown.Step = Cons.Countdown_Step;
            prsCountdown.Maximum = Cons.Countdown_Time;
            prsCountdown.Value = 0;

            tmCountdown.Interval = Cons.Countdown_Interval;

            NewGame();
        }

        void EndGame()
        {
            tmCountdown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc !!!");
        }

        void NewGame()
        {
            prsCountdown.Value = 0;
            tmCountdown.Stop();
            ChessBoard.DrawChessBoard();
        }

        void Quit()
        {
            Application.Exit();
        }

        private void tmCountdown_Tick(object sender, EventArgs e)
        {
            prsCountdown.PerformStep();
            label2.Text = (prsCountdown.Maximum / 1000 - prsCountdown.Value / 1000).ToString();

            if (prsCountdown.Value >= prsCountdown.Maximum)
            {
                EndGame();
            }
        }

        private void ChessBoard_Ended_Game(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ChessBoard_Player_Marked(object sender, ButtonClickEvent e)
        {
            tmCountdown.Start();
            prsCountdown.Value = 0;
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            NewGame();

            pnlChessBoard.Enabled = true;
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void Battle_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ra ?", "Thông báo !!!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Battle_Client_Load(object sender, EventArgs e)
        {
           
        }

        

        private void label3_Click(object sender, EventArgs e)
        { }

        private void StartButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(ServerPorttextBox.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(ClientIPtextBox.Text), int.Parse(ClientPorttextBox.Text));

            try
            {
                client.Connect(IpEnd);

                if (client.Connected)
                {
                    ChatScreentextBox.AppendText("Connected to server" + "\r\n");
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatScreentextBox.AppendText("You:" + recieve + "\r\n");
                    }));
                    recieve = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                this.ChatScreentextBox.Invoke(new MethodInvoker(delegate ()
                {
                    ChatScreentextBox.AppendText("Me:" + TextToSend + "\r\n");
                }));
            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker2.CancelAsync();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (MessagetextBox.Text != "")
            {
                TextToSend = MessagetextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            MessagetextBox.Text = "";
        }
    }
}
