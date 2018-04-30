using System;
class CakeTycoon
{
    static void Main()
    {
        ulong nCakesHeWant = ulong.Parse(Console.ReadLine());
        decimal flourNeededOneCake = decimal.Parse(Console.ReadLine());
        int kgFlourAvailable = int.Parse(Console.ReadLine());
        int truffleAvailable = int.Parse(Console.ReadLine());
        int trufflePrice = int.Parse(Console.ReadLine());

        decimal cakesHeCanMake = kgFlourAvailable / flourNeededOneCake;
        long trufellsCost = truffleAvailable * (long)trufflePrice;
        

        if (cakesHeCanMake < nCakesHeWant)
        {
            
            decimal flourKgNeeded = (nCakesHeWant * flourNeededOneCake) - kgFlourAvailable;
            Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour",(int)cakesHeCanMake,flourKgNeeded);
        }
        else
        {
            decimal priceOneCake = ((decimal)trufellsCost / nCakesHeWant) * 1.25m;
            Console.WriteLine("All products available, price of a cake: {0:f2}",priceOneCake);
        }

    }
}

