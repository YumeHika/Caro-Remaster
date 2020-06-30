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


namespace Battle_Client
{
    public partial class Battle_Client : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        #region Properties
        Chess_Board_Manager ChessBoard;
        #endregion

        public Battle_Client()
        {
            InitializeComponent();

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

        private void btnSend_Click(object sender, EventArgs e)
        {
            readData = "Conected to Chat Server ...";
            msg();
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[10025];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }

        private void msg()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            else
                textBox1.Text = textBox1.Text + Environment.NewLine + " >> " + readData;
        }




        private void Battle_Client_Load(object sender, EventArgs e)
        {}
        private void label3_Click(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
