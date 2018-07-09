using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public abstract class Obstacles
    {
        protected Obstacles NextObstacles;

        private int _sqaure;

        protected Obstacles(Obstacles nextObstacles)
        {
            this.NextObstacles = nextObstacles;
            _sqaure = 0;
        }

        protected abstract int GetNewSquare(int distince);

        public void EncounterObstacle(int distince)
        {
            var newSquare = GetNewSquare(distince);

            if (distince == newSquare)
            {
                if (this.NextObstacles != null)
                {
                    this.NextObstacles.EncounterObstacle(distince);
                    newSquare = this.NextObstacles._sqaure;
                }
            }

            _sqaure = newSquare;
        }

        public int GetResultSquare() => _sqaure;

        protected void EncounterAlert(string obstacleName) => Console.WriteLine($"--- [{obstacleName}] Encountered!");
    }

    public class Snakes : Obstacles
    {
        private readonly Dictionary<int, int> _obstacles = new Dictionary<int, int>()
        {
            {99, 80},
            {95, 75},
            {92, 88},
            {89, 68},
            {74, 53},
            {64, 60},
            {62, 19},
            {49, 11},
            {46, 25},
            {16, 6}
        };

        public Snakes(Obstacles nextObstacles) : base(nextObstacles)
        {
        }

        protected override int GetNewSquare(int distince)
        {
            if (_obstacles.ContainsKey(distince))
            {
                EncounterAlert("Snake");
                return _obstacles[distince];
            }

            return distince;
        }
    }

    public class Ladders : Obstacles
    {
        private readonly Dictionary<int, int> _obstacles = new Dictionary<int, int>()
        {
            {2, 38},
            {7, 14},
            {8, 31},
            {15, 26},
            {21, 42},
            {28, 84},
            {36, 44},
            {51, 67},
            {71, 91},
            {78, 98},
            {87, 94}
        };

        public Ladders(Obstacles nextObstacles) : base(nextObstacles)
        {
        }

        protected override int GetNewSquare(int distince)
        {
            if (_obstacles.ContainsKey(distince))
            {
                EncounterAlert("Ladder");
                return _obstacles[distince];
            }

            return distince;
        }
    }
}
