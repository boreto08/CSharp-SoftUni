using System;
class Program
{
    static void Main()
    {
        //On the first row we receive day of week 0 (Monday).
        //On the second how much money Bai Ivan has (10 leva) and on the third one we get how much alcohol he wants to drink (1 liter).
        //On Monday a liter of alcohol costs 25 leva so he can afford 10 / 25 = 0.4 liters. This is not enough for him to get drunk so he stays SOBER.
        //This amount of alcohol is less that he wanted to drink so we print on the console that he wanted to drink 0.60 liters more.

        int day = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());
        decimal liters = decimal.Parse(Console.ReadLine());
        decimal boughtAlcohol = 0m;
        string status;
        switch (day)
        {
            case 0: boughtAlcohol= money / 25M; break;
            case 1: boughtAlcohol= money / 21M;break;
            case 2: boughtAlcohol= money / 14M; break;
            case 3: boughtAlcohol= money / 17M; break;
            case 4: boughtAlcohol= money / 45M; break;
            case 5: boughtAlcohol= money / 59M; break;
            case 6: boughtAlcohol = money / 42M; break;
            default: Console.WriteLine("Wrong input");
                break;
        }
        if (boughtAlcohol < 1m)
	    {
		     status = "sober";
	    }
        else if (boughtAlcohol >= 1m && boughtAlcohol <= 1.5m)
	    {
		     status = "drunk";
	    }
        else
	    {
            status = "very drunk";
	    }
	    
        if (boughtAlcohol < liters)
	    {
		  Console.WriteLine("Bai Ivan is {1} and quite sad. He wanted to drink another {0} l. of alcohol",liters-boughtAlcohol , status);
	    }
        else if (boughtAlcohol == liters)
	    {
		 Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted",status);
	    }
        else
	    {
            Console.WriteLine("Bai Ivan is {1} and very happy and he shared {0} l. of alcohol with his friends", boughtAlcohol - liters, status);
	    }

    }
}

