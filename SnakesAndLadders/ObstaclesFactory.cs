using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class ObstaclesFactory
    {
        public static Obstacles GetObstacles()
        {
            return new Snakes(new Ladders(null));
        }
    }
}
