using System;

class CurrencyConventor
{
    static void Main()
    {
        //  USD         EUR   GBP
        //1.79549	1.95583	2.53405
        double cash = double.Parse(Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();
        double result = 0.0;
        double EUR = 1.95583;
        double GBP = 2.53405;
        double USD = 1.79549;

        if (from == "BGN")
        {
            if (to == "EUR")
            {
                result = cash / EUR;
                Console.WriteLine("{0:f2} EUR", result);
            }
            else if (to == "USD")
            {
                result = cash / USD;
                Console.WriteLine("{0:f2} USD", result);
            }
            else if (to == "GBP")
            {
                result = cash / GBP;
                Console.WriteLine("{0:f2} GBP", result);
            }
        }
        else if (from == "EUR")
        {
            cash = cash * EUR;
            if (to == "BGN")
            {
                result = cash;
                Console.WriteLine(Math.Round(result, 2) + " BGN");
            }
            else if (to == "USD")
            {
                result = cash / USD;
                Console.WriteLine("{0:f2} USD", result);
            }
            else if (to == "GBP")
            {
                result = cash / GBP;
                Console.WriteLine("{0:f2} GBP", result);
            }
        }
        else if (from == "USD")
        {
            cash = cash * USD;
            if (to == "BGN")
            {
                result = cash;
                Console.WriteLine(Math.Round(result, 2) + " BGN");
            }
            else if (to == "EUR")
            {
                result = cash / EUR;
                Console.WriteLine("{0:f2}  EUR", result);
            }
            else if (to == "GBP")
            {
                result = cash / GBP;
                Console.WriteLine("{0:f2}  GBP", result);
            }
        }
        else if (from == "GBP")
        {
            cash = cash * GBP;
            if (to == "BGN")
            {
                result = cash;
                Console.WriteLine(Math.Round(result, 2) + " BGN");
            }
            else if (to == "USD")
            {
                result = cash / USD;
                Console.WriteLine("{0:f2} USD", result);
            }
            else if (to == "EUR")
            {
                result = cash / EUR;
                Console.WriteLine("{0:f2}  EUR", result);
            }
        }
        
    }
}

