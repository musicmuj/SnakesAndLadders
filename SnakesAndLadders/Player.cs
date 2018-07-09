using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Player
    {
        public string Name { get; set; }
        public int Square { get; set; }

        public Player(string name, int currentSquare = 0)
        {
            this.Name = name;
            this.Square = currentSquare;
        }
    }
}
