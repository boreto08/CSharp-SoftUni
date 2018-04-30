using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BabaTincheAirlines
    {
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');
            string[] thirdLine = Console.ReadLine().Split(' ');

            int passengersFirstClass = int.Parse(firstLine[0]);
            int frequentFlyersFirstClass = int.Parse(firstLine[1]);
            int purchaseMealFirstClass = int.Parse(firstLine[2]);

            int passengersBusinessClass = int.Parse(secondLine[0]);
            int frequentFlyersBusinessClass = int.Parse(secondLine[1]);
            int purchaseMealBusinessClass = int.Parse(secondLine[2]);

            int passengersEconomyClass = int.Parse(thirdLine[0]);
            int frequentFlyersEconomyClass = int.Parse(thirdLine[1]);
            int purchaseMealEconomyClass = int.Parse(thirdLine[2]);

            int ticketPriceFirstClass = 7000;
            int ticketPriceBusinessClass = 3500;
            int ticketPriceEconomyClass = 1000;

            int ticketPriceOffFirstClass = CalculateDiscont(ticketPriceFirstClass);
            int ticketPriceOffBusinessClass = CalculateDiscont(ticketPriceBusinessClass);
            int ticketPriceOffEconomyClass = CalculateDiscont(ticketPriceEconomyClass);
            
            decimal income = 0;
            decimal maxIncome = 0;

            decimal mealCostFristClass = CalculateMealPrice(ticketPriceFirstClass);
            decimal mealCostBusinessClass = CalculateMealPrice(ticketPriceBusinessClass);
            decimal mealCostEconomyClass = CalculateMealPrice(ticketPriceEconomyClass);
            

            income = income+((passengersFirstClass - frequentFlyersFirstClass) * ticketPriceFirstClass) + 
                      (frequentFlyersFirstClass * ticketPriceOffFirstClass) + 
                      (purchaseMealFirstClass * mealCostFristClass);

            income = income+((passengersBusinessClass - frequentFlyersBusinessClass) * ticketPriceBusinessClass) +
                      (frequentFlyersBusinessClass * ticketPriceOffBusinessClass) +
                      (purchaseMealBusinessClass * mealCostBusinessClass);

            income = income+ ((passengersEconomyClass - frequentFlyersEconomyClass) * ticketPriceEconomyClass) +
                      (frequentFlyersEconomyClass * ticketPriceOffEconomyClass) +
                      (purchaseMealEconomyClass * mealCostEconomyClass);

            maxIncome += (12 * ticketPriceFirstClass) + (12 * mealCostFristClass);
            maxIncome += (28 * ticketPriceBusinessClass) + (28 * mealCostBusinessClass);
            maxIncome += (50 * ticketPriceEconomyClass) + (50 * mealCostEconomyClass);

            int diff = (int)maxIncome-(int)income;

            Console.WriteLine((int)income);
            Console.WriteLine(diff);
        }

        static int CalculateDiscont(int ticketPrice)
        {
            int result = 0;
            result = ticketPrice - (ticketPrice * 70 / 100);
            return result;
        }
        static decimal CalculateMealPrice(int ticketPrice)
        {
            decimal result = 0m;
            result = ticketPrice * 0.5m / 100;
            return result;
        }
    }

