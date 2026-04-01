using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;
using System.Diagnostics;
namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }

        public bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;

        }

        void EndGame()
        {

            lbTurn.Text = "Game Over";
            switch (GameStatus.Winner)
            {

                case enWinner.Player1:

                    lbWinner.Text = "Player1";
                    break;

                case enWinner.Player2:

                    lbWinner.Text = "Player2";
                    break;

                default:

                    lbWinner.Text = "Draw";
                    break;

            }

            MessageBox.Show("GameOver", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void CheckWinner()
        {


            //checked rows
            //check Row1
            if (CheckValues(button3, button2, button1))
                return;

            //check Row2
            if (CheckValues(button4, button5, button6))
                return;

            //check Row3
            if (CheckValues(button7, button8, button9))
                return;

            //checked cols
            //check col1
            if (CheckValues(button1, button4, button7))
                return;

            //check col2
            if (CheckValues(button2, button5, button8))
                return;

            //check col3
            if (CheckValues(button3, button6, button9))
                return;

            //check Diagonal

            //check Diagonal1
            if (CheckValues(button3, button5, button7))
                return;

            //check Diagonal2
            if (CheckValues(button1, button5, button9))
                return;


        }

        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lbTurn.Text = "Player 2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lbTurn.Text = "Player 1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }

            else
            {
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void ResetButtom(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            ResetButtom(button3);
            ResetButtom(button2);
            ResetButtom(button1);
            ResetButtom(button4);
            ResetButtom(button5);
            ResetButtom(button6);
            ResetButtom(button7);
            ResetButtom(button8);
            ResetButtom(button9);

            PlayerTurn = enPlayer.Player1;
            lbTurn.Text = "PLAYER 1";
            GameStatus.PlayCount = 0;
            GameStatus.GameOver = false;
            GameStatus.Winner = enWinner.GameInProgress;
            lbWinner.Text = "In Progress";


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            using (Pen whitePen = new Pen(white, 15))
            {
                whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                int gridWidth = 600;   // ⬅️ increa
                int gridHeight = 550;  

                int startX = (this.ClientSize.Width - gridWidth) / 2;
                int startY = (this.ClientSize.Height - gridHeight) / 2;

                int cellWidth = gridWidth / 3;
                int cellHeight = gridHeight / 3;

                // Horizontal lines
                e.Graphics.DrawLine(whitePen, startX, startY + cellHeight, startX + gridWidth, startY + cellHeight);
                e.Graphics.DrawLine(whitePen, startX, startY + 2 * cellHeight, startX + gridWidth, startY + 2 * cellHeight);

                // Vertical lines
                e.Graphics.DrawLine(whitePen, startX + cellWidth, startY, startX + cellWidth, startY + gridHeight);
                e.Graphics.DrawLine(whitePen, startX + 2 * cellWidth, startY, startX + 2 * cellWidth, startY + gridHeight);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://t.me/codeandcognition",
                UseShellExecute = true
            });
        }
    }
}
