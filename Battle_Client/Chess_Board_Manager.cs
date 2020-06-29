using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Battle_Client
{
    public class Chess_Board_Manager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private List<Player> player;
        public List<Player> Player { get => player; set => player = value; }

        private int Current_Player;
        public int Current_Player1 { get => Current_Player; set => Current_Player = value; }

        private TextBox PlayerName;
        public TextBox playername { get => PlayerName; set => PlayerName = value; }

        private PictureBox PlayerMark;
        public PictureBox playermark { get => PlayerMark; set => PlayerMark = value; }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> Player_Marked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler EndedGame;
        public event EventHandler Ended_Game
        {
            add
            {
                EndedGame += value;
            }
            remove
            {
                EndedGame -= value;
            }
        }

        private Stack<PlayInfo> playTimeLine;
        public Stack<PlayInfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }
        #endregion

        #region Initialize
        public Chess_Board_Manager(Panel chessBoard, TextBox Player_Name, PictureBox Mark)
        {
            this.ChessBoard = chessBoard;
            this.playername = Player_Name;
            this.playermark = Mark;

            this.Player = new List<Player>()
            {
                new Player("Player_1", Image.FromFile(Application.StartupPath + "\\Resources\\X.png")),
                new Player("Player_2", Image.FromFile(Application.StartupPath + "\\Resources\\O.png"))
            };

            PlayTimeLine = new Stack<PlayInfo>();
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

            PlayTimeLine = new Stack<PlayInfo>();

            Current_Player = 0;

            ChangePlayer();

            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };

            for (int i = 0; i <= Cons.Chess_Board_Height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Cons.Chess_Board_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.Chess_Width,
                        Height = Cons.Chess_Height,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    ChessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn.Location = new Point(0, oldBtn.Location.Y + Cons.Chess_Height);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }
        void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), Current_Player));

            Current_Player = Current_Player == 1 ? 0 : 1;

            ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new PlayInfo(GetChessPoint(btn), Current_Player));

            Current_Player = Current_Player == 1 ? 0 : 1;

            ChangePlayer();

            if (isEndGame(btn))
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            if (EndedGame != null)
                EndedGame(this, new EventArgs());
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;

            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;

            for (int i = point.X + 1; i < Cons.Chess_Board_Width; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;

            for (int i = point.Y + 1; i < Cons.Chess_Board_Height; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;

            for (int i = 1; i <= Cons.Chess_Board_Width - point.X; i++)
            {
                if (point.Y + i > Cons.Chess_Board_Height || point.X + i >= Cons.Chess_Board_Width)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;

            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Cons.Chess_Board_Width || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;

            for (int i = 1; i <= Cons.Chess_Board_Width - point.X; i++)
            {
                if (point.Y + i > Cons.Chess_Board_Height || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[Current_Player].Mark;
        }
        private void ChangePlayer()
        {
            playername.Text = Player[Current_Player].Name;

            playermark.Image = Player[Current_Player].Mark;
        }
        #endregion
    }

    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }

        public ButtonClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }
}
