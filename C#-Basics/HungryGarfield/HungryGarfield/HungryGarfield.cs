using System;
class HungryGarfield
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        decimal dolarRate = decimal.Parse(Console.ReadLine());
        decimal pizzaPrice = decimal.Parse(Console.ReadLine());
        decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
        decimal sandwichPrice = decimal.Parse(Console.ReadLine());
        decimal quantityPizza = decimal.Parse(Console.ReadLine());
        decimal quantityLasagna = decimal.Parse(Console.ReadLine());
        decimal quantitySandwich = decimal.Parse(Console.ReadLine());

        decimal  sum =  ((pizzaPrice / dolarRate) * quantityPizza) 
                    + ((lasagnaPrice / dolarRate) * quantityLasagna)
                    + ((sandwichPrice / dolarRate) * quantitySandwich);
        if (sum < cash)
        {
            Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", cash-sum);
        }
        else
	    {
            Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.",sum -cash);
	    }
    }
}

