using AIgorOS.Methods.Music;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AIgorOS.Methods.Music.SoundEffects.TrackName;

namespace AIgorOS.Methods.Calculate
{
    public class Calc
    {
        private SoundEffects musi = new SoundEffects();
        private int alarm = 0;
        private Regex regex = new Regex("[^0-9]");
        private double sum;


        public double Calculating(double ftnum, double sdnum, string sign, TextBox t)
        {
            musi.Play(GRATULACJE);
            switch (sign)
            {
                case "+": sum = ftnum + sdnum; break;
                case "-": sum = ftnum - sdnum; break;
                case "*": sum = ftnum * sdnum; break;
                case "÷":
                    if (sdnum == 0)
                    {
                        alarm++;
                        if (alarm == 1)
                        {
                            musi.Play(ALERT1);
                            sum = 0;
                        }
                        else if (alarm == 2)
                        {
                            musi.Play(ALERT2);
                            sum = 0;
                        }
                        else if (alarm == 3)
                        {
                            musi.Play(ALERT);
                            foreach (Form frm in Application.OpenForms)
                            {
                                frm.WindowState = FormWindowState.Maximized;
                                frm.Size = new System.Drawing.Size(9999, 99900);
                                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                                t.Hide();
                            }
                            Thread.Sleep(28000);
                            Process.Start("shutdown.exe", "-s -t 00");
                            sum = 0;
                        }

                    }
                    else
                        sum = ftnum / sdnum; break;
            }
            return sum;
        }
        public double MathPow(double num)
        {
            num = Math.Pow(num, 2);
            return num;
        }
        public double PerCent(double num)
        {
            return num / 100;
        }
        public double CalcSqrt(double num)
        {
            sum = Math.Sqrt(num);
            return sum;
        }
        public bool IsItNumber(TextBox t)
        {
            if (regex.IsMatch(t.Text))
            {
                return false;
            }
            return true;
        }
    }
}
