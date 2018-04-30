using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSeven = false;

        int preparation = number / 100;
        int lastDigit = preparation % 10;
        if ( lastDigit == 7  )
        {
            isSeven = true;
            Console.WriteLine(isSeven);
        }
        else
        {
            Console.WriteLine(isSeven);
        }

    }
}

