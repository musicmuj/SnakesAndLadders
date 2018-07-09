using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Dice
    {
        private Random _randomSvc;

        public Dice()
        {
            _randomSvc = new Random();
        }

        public int Shake()
        {
            return _randomSvc.Next(6) + 1;
        }
    }
}
