using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class SnakesLaddersGame
    {
        private readonly Dictionary<int, Player> _players;
        private readonly int _playerCount;

        private int _nextPlayer;
        private int _gameStep;

        public SnakesLaddersGame(Dictionary<int, Player> players)
        {
            _players = players;
            _playerCount = players.Count;
            _gameStep = 0;
        }

        public void Play(int point1, int point2)
        {
            var player = _players[_nextPlayer];

            var totalSteps = point1 + point2;
            var distance = player.Square + totalSteps;

            player.Square = MoveOn(distance);

            if (point1 != point2)
                _gameStep += 1;

            _nextPlayer = _gameStep % _playerCount;
        }

        public int GetPlayerSquare(string name)
        {
            var player = _players.Values.Where(p => p.Name == name).SingleOrDefault();

            return player?.Square ?? -1;
        }

        private int MoveOn(int distance)
        {
            var obstacles = ObstaclesFactory.GetObstacles();
            obstacles.EncounterObstacle(distance);

            var resultSqaure = obstacles.GetResultSquare();
            return resultSqaure;
        }
    }
}
