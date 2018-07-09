using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("      Snakes and Ladders Game      ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            var isContinue = false;

            do
            {
                try
                {
                    var players = GetPlayers();

                    SnakesLaddersGame gameSvc = new SnakesLaddersGame(players);
                    Dice dice = new Dice();

                    while (!gameSvc.CheckIsGameOver())
                    {
                        gameSvc.Play(dice.Shake(), dice.Shake());
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception expetion)
                {
                    Console.WriteLine(expetion);
                }
                finally
                {
                    Console.WriteLine("Still want to continue? Y/N");
                    var answer = Console.ReadLine()?? string.Empty;
                    isContinue = answer.Equals("Y", StringComparison.OrdinalIgnoreCase);
                }

            } while (isContinue);
        }

        private static Dictionary<int, Player> GetPlayers()
        {
            var players = new Dictionary<int, Player>();

            Console.WriteLine("[ Players ]");
            Console.Write("How many players:");
            var playerCount = Convert.ToInt32(Console.ReadLine());

            for (int index = 0; index < playerCount; index++)
            {
                Console.Write($"Player {index + 1} Name: ");
                var name = Console.ReadLine();

                Player player = new Player(name);
                players.Add(index, player);
            }

            return players;
        }
    }
}
