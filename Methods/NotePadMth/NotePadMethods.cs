using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIgorOS.Methods.NotePad
{
    public class NotePadMethods
    {
        public string OpenFile()
        {
            string Decode;
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.InitialDirectory = "c:\\";
            OpenFile.Filter = "Access files (*.txt)|*.txt";
            OpenFile.FilterIndex = 2;
            OpenFile.RestoreDirectory = true;

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                var path = OpenFile.FileName;
                return Decode = File.ReadAllText(path);
            }
            return "";
        }
        public void GetFonts()
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();          
        }
        public void SaveFile(string Text)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.InitialDirectory = "c:\\";
            SaveFile.Filter = "Access files (*.txt)|*.txt";
            SaveFile.FilterIndex = 2;
            SaveFile.RestoreDirectory = true;

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                var path = SaveFile.FileName;
                File.WriteAllText(path, Text);
            }
        }
        public string EncodeText(string Text)
        {
            int k = 0;
            char[] TextToEncode = Text.ToCharArray();
            int TextLength = Text.Length;
            char[] OutArray = new char[TextLength + 1];

            for (int i = 0; i < TextLength; i++)
            {
                if (OutArray[i] % 2 == 1)
                {
                    k += 1;
                    OutArray[i] = (char)(TextToEncode[i] + k++);
                }
                else if (OutArray[i] % 2 == 0)
                {
                    k += 2;
                    OutArray[i] = (char)(TextToEncode[i] + k++);
                }
            }
            return new string(OutArray);
        }
        public string DecodeText(string Text)
        {
            int k = 0;
            char[] TextToEncode = Text.ToCharArray();
            int TextLength = Text.Length;
            char[] OutArray = new char[TextLength + 1];

            for (int i = 0; i < TextLength; i++)
            {
                if (OutArray[i] % 2 == 1)
                {
                    k += 1;
                    OutArray[i] = (char)(TextToEncode[i] - k++);
                }
                else if (OutArray[i] % 2 == 0)
                {
                    k += 2;
                    OutArray[i] = (char)(TextToEncode[i] - k++);
                }
            }
            return new string(OutArray);
        }
    }
}
