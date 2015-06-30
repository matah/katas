// Details: https://en.wikipedia.org/wiki/Monty_Hall_problem
// Numberphile Video: https://www.youtube.com/watch?v=4Lb-6rxZxx0

using System;

namespace MontyHallProblem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            switch (args[0])
            {
                case "justdoit":
                    FirstWay();
                    break;
                case "think":
                    SecondWay();
                    break;
                default:
                    Console.Write("Can't read that, sorry. Press any key to exit!");
                    Console.ReadLine();
                    break;
            }
        }

        public static void FirstWay()
        {
            const int numberTrials = 1000000;
            var switchWins = 0;
            var stayWins = 0;

            var gen = new Random();

            for (var plays = 0; plays < numberTrials; plays++)
            {
                int[] doors = {0, 0, 0};

                var winner = gen.Next(3);
                doors[winner] = 1; 

                var choice = gen.Next(3); 
                int shown; 
                do
                {
                    shown = gen.Next(3);
                } while (doors[shown] == 1 || shown == choice);

                stayWins += doors[choice];

                switchWins += doors[3 - choice - shown];
            }

            Console.WriteLine("Staying wins {0}. Probability is: {1}", stayWins, ((stayWins * 1.0 / numberTrials) * 100));
            Console.WriteLine("Switching wins {0}. Probability is: {1}", switchWins, ((switchWins * 1.0 / numberTrials) * 100));
        }

        private static void SecondWay()
        {
            throw new NotImplementedException();
        }
    }
}