using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIgorOS
{
    public partial class GameChoice : Form
    {
        private TicTacToe TTT;  
        private HotPursuit HP;

        public GameChoice()
        {
            InitializeComponent();
        }

        private void TicTacButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTT = new TicTacToe();
            TTT.Closed += (s, args) => this.Close();
            TTT.Show();
        }

        private void RaceButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            HP = new HotPursuit();
            HP.Closed += (s, args) => this.Close();
            HP.Show();
        }
        private void ExitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GameChoice_Load(object sender, EventArgs e)
        {

        }
    }
}
