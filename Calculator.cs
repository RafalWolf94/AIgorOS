using AIgorOS.Methods.Calculate;
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
    public partial class Calculator : Form
    {

        private SoundEffects music = new SoundEffects();
        private Calc calc = new Calc();
        private string sign = null;
        private bool Check = false;
        private double ftnum, sdnum;
        private bool ChangeState = false;
        private string num;
        public Calculator() => InitializeComponent();
        private void TextGetter_TextChanged(object sender, EventArgs e) { }
        private void GetDigits(object sender, EventArgs e)
        {
            num = ((Button)sender).Text;
            PlaySounds(num);
            if (Check)
            {
                try
                {
                    ftnum = double.Parse(TextGetter.Text);
                    TextGetter.Text = "";
                    Check = !Check;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            TextGetter.Text += ((Button)sender).Text;
        }
        private void GetOperator(object sender, EventArgs e)
        {
            if (TextGetter.TextLength > 0)
            {
                try
                {                
                sign = ((Button)sender).Text;
                PlaySounds(sign);
                Check = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void SumClicl(object sender, EventArgs e)
        {
            music.Play(SUMA);
            try
            {
                sdnum = double.Parse(TextGetter.Text);
                TextGetter.Text = calc.Calculating(ftnum, sdnum, sign, TextGetter).ToString();
                Check = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DotClick(object sender, EventArgs e)
        {
            music.Play(PRZECINEK);
            TextGetter.Text += ",";
        }
        private void SqrtRoot(object sender, EventArgs e)
        {
            music.Play(PIERWIASTEK);
            try
            {
                TextGetter.Text = calc.CalcSqrt(double.Parse(TextGetter.Text)).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PowerClick(object sender, EventArgs e)
        {
            music.Play(DOPOTEGI);
            try
            {
                TextGetter.Text = calc.MathPow(double.Parse(TextGetter.Text)).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PerCentClick(object sender, EventArgs e)
        {
            music.Play(PROCENT);
            try
            {
                TextGetter.Text = calc.PerCent(double.Parse(TextGetter.Text)).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearClick(object sender, EventArgs e)
        {
            music.Play(C);
            TextGetter.Clear();
        }
        private void ClearElemetClick(object sender, EventArgs e)
        {
            music.Play(CE);
            if (TextGetter.TextLength > 0)
                TextGetter.Text = TextGetter.Text.Remove(TextGetter.Text.Length - 1);
        }
        private void ReturnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        #region //Music
        private void MusicClick(object sender, EventArgs e)
        {
            ChangeState = !ChangeState;

            if (ChangeState)
            {
                MusicButt.Text = "♪";
                music.Play(MENU);
            }
            else
            {
                MusicButt.Text = "♫";
                music.Play(O_MACIEJ);
            }
        }
        private void Calculator_Load(object sender, EventArgs e) { }
        private void PlaySounds(string x)
        {
            switch (x)
            {
                case "0": music.Play(ZERO); break;
                case "1": music.Play(JEDEN); break;
                case "2": music.Play(DWA); break;
                case "3": music.Play(TRZY); break;
                case "4": music.Play(CZTERY); break;
                case "5": music.Play(PIEC); break;
                case "6": music.Play(SZCZESC); break;
                case "7": music.Play(SIEDEM); break;
                case "8": music.Play(OSIEM); break;
                case "9": music.Play(DZIEWIEC); break;
                case "+": music.Play(PLUS); break;
                case "-": music.Play(MINUS); break;
                case "÷": music.Play(PODZIELIC); break;
                case "*": music.Play(RAZY); break;
                default: break;
            }
        }
        #endregion
    }
}
