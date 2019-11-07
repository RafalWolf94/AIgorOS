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
    public partial class HotPursuit : Form
    {
        private int gamespeed = 0;
        private SoundEffects music = new SoundEffects();
        private Random randomplace = new Random();
        private int x;
        private int collectedcoin = 0;
        public HotPursuit()
        {
            music.Play(CARRACE);
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Moveline(gamespeed);
            Enemy(gamespeed);
            CollectedCoins();
            Coins(gamespeed);
            Gameover();
        }
        private void Moveline(int speed)
        {

            if (PBOne.Top >= 700) { PBOne.Top = 0; }
            else { PBOne.Top += speed; }

            if (PBTwo.Top >= 700) { PBTwo.Top = 0; }
            else { PBTwo.Top += speed; }

            if (PBThree.Top >= 700) { PBThree.Top = 0; }
            else { PBThree.Top += speed; }

            if (PBfour.Top >= 700) { PBfour.Top = 0; }
            else { PBfour.Top += speed; }

            if (PBFive.Top >= 700) { PBFive.Top = 0; }
            else { PBFive.Top += speed; }
        }
        private void Enemy(int speed)
        {
            if (Tank.Top >= 700)
            {
                x = randomplace.Next(0, 100);
                Tank.Location = new Point(x, 0);
            }
            else { Tank.Top += speed; }
            if (Tank2.Top >= 700)
            {
                x = randomplace.Next(50, 700);
                Tank2.Location = new Point(x, 0);
            }
            else { Tank2.Top += speed; }
            if (Tank3.Top >= 700)
            {
                x = randomplace.Next(100, 300);
                Tank3.Location = new Point(x, 0);
            }
            else { Tank3.Top += speed; }
        }

        private void Player_Move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Player.Left > 0)
                    Player.Left += -20;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Player.Right < 380)
                    Player.Left += 20;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                    gamespeed++;
            }
        }
        private void Coins(int speed)
        {
            if (Coin1.Top >= 700)
            {
                x = randomplace.Next(0, 100);
                Coin1.Location = new Point(x, 0);
            }
            else { Coin1.Top += speed; }
            if (Coin2.Top >= 700)
            {
                x = randomplace.Next(50, 200);
                Coin2.Location = new Point(x, 0);
            }
            else { Coin2.Top += speed; }
            if (Coin3.Top >= 700)
            {
                x = randomplace.Next(100, 300);
                Coin3.Location = new Point(x, 0);
            }
            else { Coin3.Top += speed; }
            if (Coin4.Top >= 700)
            {
                x = randomplace.Next(100, 300);
                Coin4.Location = new Point(x, 0);
            }
            else { Coin4.Top += speed; }
        }

        private void Gameover()
        {
            if (Player.Bounds.IntersectsWith(Tank.Bounds) ||
                Player.Bounds.IntersectsWith(Tank2.Bounds) ||
                Player.Bounds.IntersectsWith(Tank3.Bounds))
            {
                StartButt.Visible = true;
                Timer.Enabled = false;
                OverLabel.Visible = true;
                ReturnButt.Visible = true;
            }
        }
        private void CollectedCoins()
        {
            if (Player.Bounds.IntersectsWith(Coin1.Bounds))
            {
                collectedcoin += 1;
                CoinsLabel.Text = "Monety=" + collectedcoin.ToString();
                Coin1.Location = new Point(x, 0);
            }

            if (Player.Bounds.IntersectsWith(Coin2.Bounds))
            {
                collectedcoin += 1;
                CoinsLabel.Text = "Monety=" + collectedcoin.ToString();
                Coin2.Location = new Point(x, 0);
            }
            if (Player.Bounds.IntersectsWith(Coin3.Bounds))
            {
                collectedcoin += 1;
                CoinsLabel.Text = "Monety=" + collectedcoin.ToString();
                Coin3.Location = new Point(x, 0);
            }
            if (Player.Bounds.IntersectsWith(Coin4.Bounds))
            {
                collectedcoin += 1;
                CoinsLabel.Text = "Monety=" + collectedcoin.ToString();
                Coin4.Location = new Point(x, 0);
            }
        }

        private void EnemyStartPosisition()
        {
            Tank.Location = new Point(50, 20);
            Tank2.Location = new Point(200, 20);
            Tank3.Location = new Point(300, 20);
        }
        private void PlayerStartPosistion() => Player.Location = new Point(170, 523);

        private void StartGame()
        {
            collectedcoin = 0;
            gamespeed = 0;
            EnemyStartPosisition();
            CoinsLabel.Text = "Monety=";
            StartButt.Visible = false;
            ReturnButt.Visible = false;
            Timer.Enabled = true;
            OverLabel.Visible = false;
            PlayerStartPosistion();
            Moveline(gamespeed);
            Enemy(gamespeed);
            Gameover();
            Coins(gamespeed);
            CollectedCoins();
            Timer.Start();
        }

        private void StartButt_Click(object sender, EventArgs e) => StartGame();

        private void ReturnButt_Click(object sender, EventArgs e) => this.Close();
    }
}
