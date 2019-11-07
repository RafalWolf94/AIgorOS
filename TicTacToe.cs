using AIgorOS.Methods.Game;
using AIgorOS.Methods.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AIgorOS.Methods.Music.SoundEffects.TrackName;
namespace AIgorOS
{
    public partial class TicTacToe : Form
    {
        private SoundEffects music = new SoundEffects();
        private GameMethods gameMth = new GameMethods();
        private Menu menu = new Menu();

        private bool move = true;
        private int end;
        private int p1point = 0;
        private int p2point = 0;
        private string p1name;
        private string p2name;

        public TicTacToe()
        {
            InitializeComponent();
        }
        #region//Buttons
        private void Btn1(object sender, EventArgs e) => CheckTurn(button1);
        private void Btn2(object sender, EventArgs e) => CheckTurn(button2);
        private void Btn3(object sender, EventArgs e) => CheckTurn(button3);
        private void Btn4(object sender, EventArgs e) => CheckTurn(button4);
        private void Btn5(object sender, EventArgs e) => CheckTurn(button5);
        private void Btn6(object sender, EventArgs e) => CheckTurn(button6);
        private void btn7(object sender, EventArgs e) => CheckTurn(button7);
        private void btn8(object sender, EventArgs e) => CheckTurn(button8);
        private void btn9(object sender, EventArgs e) => CheckTurn(button9);
        #endregion
        private void CheckTurn(Button b)
        {
            if (b.Text.Length == 0) {

                if (move)
                {
                    b.Text = "X";
                    b.ForeColor = Color.Maroon;

                    end = gameMth.Score(move, p1name, 1, b);
                    if (end == 1)
                    {
                        p1point++;
                        gameMth.reset();
                        end = 0;
                        P1ScoreLab.Text = p1point.ToString();
                        StartGame();
                    }
                    else if (end == 3)
                    {
                        end = 0;
                        gameMth.reset();
                        StartGame();
                    }

                    move = false;
                }
                else if (!move)
                {
                    b.Text = "O";
                    b.ForeColor = Color.Blue;

                    end = gameMth.Score(move, p2name, 2, b);
                    if (end == 2)
                    {
                        p2point++;
                        gameMth.reset();
                        end = 0;
                        P2ScoreLab.Text = p2point.ToString();
                        StartGame();
                    }
                    else if (end == 3)
                    {
                        end = 0;
                        gameMth.reset();
                        StartGame();
                    }

                    move = true;
                }

            }
            
        }

        private void StartGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            end = 0;
            move = true;
            EnableButtons();
        }
        private void EnableButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        private void SubButt_Click(object sender, EventArgs e)
        {
            music.PlayLoop(TICTACTOE);
            P1Lab.Hide();
            P2Lab.Hide();
            WriteNameLabel.Hide();
            P1TX.Hide();
            P2TX.Hide();
            SubButt.Hide();
            p1name = P1TX.Text;
            p2name = P2TX.Text;
            if (p1name.Length == 0 || p1name == null)
            {
                p1name = "Player 1";
                P1NameLab.Text += p1name + ":";
            }
            else P1NameLab.Text += p1name + ":";
            if (p2name.Length == 0 || p2name == null)
            {
                p2name = "Player 2";
                P2NameLab.Text += p2name + ":";
            }
            else P2NameLab.Text += p2name + ":";

            StartGame();
        }
        private void NewGameClick(object sender, EventArgs e)
        {
            gameMth.reset();
            DisableButtons();
            P1TX.Clear();
            P2TX.Clear();
            P1NameLab.Text = "X -";
            P2NameLab.Text = "O -";
            P1ScoreLab.Text = "";         
            P2ScoreLab.Text = "";
            P1Lab.Show();
            P2Lab.Show();
            WriteNameLabel.Show();
            P1TX.Show();
            P2TX.Show();
            SubButt.Show();
            p1point = 0;
            p2point = 0;

        }
        private void MenuButtonClick(object sender, EventArgs e)
        {
            this.Close();            
        }



    }

}

