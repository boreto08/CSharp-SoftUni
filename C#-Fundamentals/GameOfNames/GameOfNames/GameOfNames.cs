using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class GameOfNames
    {
        static void Main()
        {
            int players = int.Parse(Console.ReadLine());

            CalcMaxScore(players);
        }

        private static void CalcMaxScore(int players)
        {
            int maxScore = int.MinValue;
            string winnerName = null;
            for (int i = 0; i < players; i++)
            {
                string name = Console.ReadLine();
                int initialScore = int.Parse(Console.ReadLine());
                int currentScore = initialScore;

                for (int j = 0; j < name.Length; j++)
                {
                    int chCode = name[j];
                    if (chCode % 2 == 0)
                    {
                        currentScore += chCode;
                    }
                    else
                    {
                        currentScore -= chCode;
                    }
                }

                if (currentScore > maxScore)
                {
                    maxScore = currentScore;
                    winnerName = name;
                }
            }

            Console.WriteLine($"The winner is {winnerName} - {maxScore} points");
        }
    }
}
