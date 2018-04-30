using System;

class BeerStock
{
    static void Main()
    {
        int reservedBeers = int.Parse(Console.ReadLine());
        long sumBeers = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Exam Over")
            {
                break;
            }
            string[] amountAndType = input.Split();
            long amount = long.Parse(amountAndType[0]);
            string type = amountAndType[1];
            switch (type)
            {
                case "beers": 
                    sumBeers += amount; 
                    break;
                case "sixpacks": 
                    sumBeers += amount * 6; 
                    break;
                case "cases":
                    sumBeers += amount * 24;
                    break; 
            }
        }
        long broken = sumBeers / 100;
        sumBeers = sumBeers - broken;
        if (sumBeers >= reservedBeers)
        {
            long beerLeft = sumBeers - reservedBeers;
            Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", beerLeft / 24, (beerLeft % 24) / 6, (beerLeft % 24) % 6);
        }
        else
        {
            long neededBeer = reservedBeers - sumBeers;
            Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", neededBeer / 24, (neededBeer % 24) / 6, (neededBeer % 24) % 6);
        }
    }
}

