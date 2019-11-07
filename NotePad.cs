using AIgorOS.Methods.NotePad;
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
    public partial class NotePad : Form
    {     
        private NotePadMethods NotePadMethods = new NotePadMethods();
        private string TextFile;
        public NotePad()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, EventArgs e)
        {            
            TextFile = WriteBox.Text;
            NotePadMethods.SaveFile(TextFile);
        }

        private void FontClick(object sender, EventArgs e)
        {
            FontDialog fonts = new FontDialog();
            if (fonts.ShowDialog() == DialogResult.OK & !String.IsNullOrEmpty(WriteBox.Text))
                WriteBox.SelectionFont = fonts.Font;
        }

        private void CodeClick(object sender, EventArgs e)
        {
            TextFile = NotePadMethods.EncodeText(WriteBox.Text);
            NotePadMethods.SaveFile(TextFile);
        }

        private void DeCodeClick(object sender, EventArgs e) => WriteBox.Text = NotePadMethods.DecodeText(NotePadMethods.OpenFile());

        private void ReturnClick(object sender, EventArgs e)
        {       
            this.Hide();
            var form2 = new Menu();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void WriteBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
