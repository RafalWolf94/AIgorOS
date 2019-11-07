using AIgorOS.AIgor;
using AIgorOS.Methods.Music;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AIgorOS.Methods.Music.SoundEffects.TrackName;


namespace AIgorOS
{
    public partial class Menu : Form
    {
        private SoundEffects music = new SoundEffects();
        private Aigor igor = new Aigor();



        public Menu()
        {
            InitializeComponent();
            igor.SetCommands();
            igor.Igor.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);
        }

        private void CalcClick(object sender, EventArgs e)
        {            
            var form = new Calculator();
            form.Show();
        }
        private void NoteClick(object sender, EventArgs e)
        {
            var form = new NotePad();
            form.Show();
        }
        private void GameClick(object sender, EventArgs e)
        {
            var form = new GameChoice();
            form.Show();
        }
        private void ExitButt(object sender, EventArgs e)
        {
            music.Play(WIDZENIA);
            Thread.Sleep(1000);
            Application.Exit();
        }
        private void CalcHov(object sender, EventArgs e) => music.Play(KALKULATOR);
        private void NoteHov(object sender, EventArgs e) => music.Play(NOTATNIK);
        private void GameHov(object sender, EventArgs e) => music.Play(GRA);
        private void ExitHov(object sender, EventArgs e) => music.Play(EXIT);

        private void Menu_Load(object sender, EventArgs e) { music.Play(WITAJ); }
    }
}
