using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main()
        {
            int orders = int.Parse(Console.ReadLine());
            CalculateCoffePrice(orders);
        }

        private static void CalculateCoffePrice(int orders)
        {
            decimal totalSum = 0.0m;
            for (int i = 0; i < orders; i++)
            {
                decimal coffePrice = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal coffieCount = decimal.Parse(Console.ReadLine());

                decimal coffeTotalPrice = ((daysInMonth * coffieCount) * coffePrice);
                totalSum += coffeTotalPrice;
                Console.WriteLine($"The price for the coffee is: ${coffeTotalPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
