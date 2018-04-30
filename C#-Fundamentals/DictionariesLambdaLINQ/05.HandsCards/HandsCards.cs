using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsCards
{
    class HandsCards
    {
        static void Main()
        {
            Dictionary<string, Player> players = new Dictionary<string, Player>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "JOKER")
                {
                    break;
                }
                var args = input.Split(':');
                string name = args[0];
                string[] cards = args[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                Player currentPlayer = new Player();

                if (!players.ContainsKey(name))
                {
                    currentPlayer.Name = name;
                    foreach (var card in cards)
                    {
                        currentPlayer.Cards.Add(card);
                    }

                    players.Add(name, currentPlayer);
                }
                else
                {
                    foreach (var card in cards)
                    {
                        players[name].Cards.Add(card);
                    }
                }

            }

            foreach (var player in players)
            {
                int playerPoints = CalcPoints(player.Value.Cards);
                Console.WriteLine($"{player.Key}: {playerPoints}");
            }
        }

        private static int CalcPoints(HashSet<string> cards)
        {
            int result = 0;
            foreach (var card in cards)
            {
                int typePower = 0;
                int powerPoints = 0;
                string type = card[card.Length - 1].ToString();
                string power = card.Remove(card.Length - 1);

                //(S -> 4, H-> 3, D -> 2, C -> 1).
                switch (type)
                {
                    case "C": typePower = 1;
                        break;
                    case "D":
                        typePower = 2;
                        break;
                    case "H":
                        typePower = 3;
                        break;
                    case "S":
                        typePower = 4;
                        break;
                }
                switch (power)
                {
                    case "J":
                        powerPoints = 11;
                        break;
                    case "Q":
                        powerPoints = 12;
                        break;
                    case "K":
                        powerPoints = 13;
                        break;
                    case "A":
                        powerPoints = 14;
                        break;
                    default: powerPoints = int.Parse(power);
                        break;
                }
                result += powerPoints * typePower;

            }
            return result;
        }
    }
}
