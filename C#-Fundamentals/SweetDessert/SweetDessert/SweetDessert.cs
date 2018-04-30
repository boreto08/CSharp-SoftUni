using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceBerryKg = decimal.Parse(Console.ReadLine());


            decimal priceForOneSet = (2 * priceBanana) + (4 * priceEgg) + (0.2m * priceBerryKg);
            int sets = CalcSets(guests);
            decimal neededMoney = priceForOneSet * sets;

            if (money >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - money:f2}lv more.");
            }
        }

        private static int CalcSets(int guests)
        {
            if (guests % 6 == 0)
            {
                return guests / 6;
            }
            else
            {
                int sets = 0;
                while (guests % 6 != 0)
                {
                    guests++;
                }
                sets = guests / 6;
                return sets;
            }
        }
    }
}
