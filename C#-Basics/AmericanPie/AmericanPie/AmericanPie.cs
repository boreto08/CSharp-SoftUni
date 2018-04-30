using System;

class AmericanPie
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());
        decimal D = decimal.Parse(Console.ReadLine());

        decimal denominator = B * D;
        decimal bufferA = denominator / B;
        decimal bufferC = denominator / D;

        decimal nominator = (A * bufferA) + (C * bufferC);
        decimal  numberOfPies = nominator / denominator;
        if (numberOfPies >= 1 )
        {
            Console.WriteLine("{0:f0}",numberOfPies);
        }
        else
        {
            Console.WriteLine("{0:f20}",numberOfPies);
        }
        
        Console.WriteLine("{0}/{1}",nominator,denominator);

    }
}

