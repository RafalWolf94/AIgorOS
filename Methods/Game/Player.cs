using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIgorOS.Methods.Game
{
    public class Player
    {
        public string name { get; set; }
        public int score { get; set; }
        public Player() { }
        public Player(string name = "Player", int score = 0)
        {
            this.name = name;
            this.score = score;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n Score: {1}\nMove: ", name, score);
        }

    }
}
