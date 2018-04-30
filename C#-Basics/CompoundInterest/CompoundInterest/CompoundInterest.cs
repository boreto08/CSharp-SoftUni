using System;

class CompoundInterest
{
    static void Main()
    {
        //•	The number p – price of the TV.
        //•	The number n – number of years you have until you must pay the bank back (term).
        //•	The number i – the yearly interest rate for the bank’s loan.
        //•	The number f – interest rate for your friend’s loan.

        int p = int.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal i = decimal.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());

        decimal bankLoan = p * (decimal)Math.Pow((1 + (double)i), (double)n);
        decimal friendLoan = p * (1 + f);

        if (bankLoan < friendLoan)
	    {
		 Console.WriteLine("{0:f2} Bank",bankLoan);
	    }
        else if(friendLoan <= bankLoan )
	    {
            Console.WriteLine("{0:f2} Friend",friendLoan);
	    }


    }
}

