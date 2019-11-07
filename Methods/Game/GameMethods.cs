using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIgorOS.Methods.Game
{
    public class GameMethods
    {
        private int col;
        private int row;
        public int turns = 0;
        private int result = 0;
        private readonly string WonMsg = " Won this Turn!";
        private readonly string DrawMsg = "DRAW!";
        private int[,] scorearray = new int[3, 3]
       {
          {0,0,0},
          {0,0,0},
          {0,0,0}
       };

        public int Score(bool pmove, string pname, int point, Button b)
        {
            turns++;         
            
            switch (b.Name)
            {
                case "button1": col = 0; row = 0; break;
                case "button2": col = 0; row = 1; break;
                case "button3": col = 0; row = 2; break;
                case "button4": col = 1; row = 0; break;
                case "button5": col = 1; row = 1; break;
                case "button6": col = 1; row = 2; break;
                case "button7": col = 2; row = 0; break;
                case "button8": col = 2; row = 1; break;
                case "button9": col = 2; row = 2; break;
            }
            if (pmove)
            {
                scorearray[col, row] = point;

                if (scorearray[0, 0] == 1 && scorearray[0, 1] == 1 && scorearray[0, 2] == 1 ||
                    scorearray[1, 0] == 1 && scorearray[1, 1] == 1 && scorearray[1, 2] == 1 ||
                    scorearray[2, 0] == 1 && scorearray[2, 1] == 1 && scorearray[2, 2] == 1 ||
                    scorearray[0, 0] == 1 && scorearray[1, 0] == 1 && scorearray[2, 0] == 1 ||
                    scorearray[0, 1] == 1 && scorearray[1, 1] == 1 && scorearray[2, 1] == 1 ||
                    scorearray[0, 2] == 1 && scorearray[1, 2] == 1 && scorearray[2, 2] == 1 ||
                    scorearray[0, 0] == 1 && scorearray[1, 1] == 1 && scorearray[2, 2] == 1 ||
                    scorearray[0, 2] == 1 && scorearray[1, 1] == 1 && scorearray[2, 0] == 1)
                {
                    MessageBox.Show(pname + WonMsg);

                    result = 1;
                }
            }
            else if (!pmove)
            {
                scorearray[col, row] = point;

                if (scorearray[0, 0] == 2 && scorearray[0, 1] == 2 && scorearray[0, 2] == 2 ||
                    scorearray[1, 0] == 2 && scorearray[1, 1] == 2 && scorearray[1, 2] == 2 ||
                    scorearray[2, 0] == 2 && scorearray[2, 1] == 2 && scorearray[2, 2] == 2 ||
                    scorearray[0, 0] == 2 && scorearray[1, 0] == 2 && scorearray[2, 0] == 2 ||
                    scorearray[0, 1] == 2 && scorearray[1, 1] == 2 && scorearray[2, 1] == 2 ||
                    scorearray[0, 2] == 2 && scorearray[1, 2] == 2 && scorearray[2, 2] == 2 ||
                    scorearray[0, 0] == 2 && scorearray[1, 1] == 2 && scorearray[2, 2] == 2 ||
                    scorearray[0, 2] == 2 && scorearray[1, 1] == 2 && scorearray[2, 0] == 2)
                {
                    MessageBox.Show(pname + WonMsg);

                    result = 2;
                }
            }

            if (turns == 9 && result == 0)
            {
                result = 3;
                MessageBox.Show(DrawMsg);

            }
            return result;
        }
        public void reset()
        {
            result = 0;
            turns = 0;
            ClearArray();
        }
        private void ClearArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    scorearray[i, j] = 0;
                }
            }
        }       
    }
}
