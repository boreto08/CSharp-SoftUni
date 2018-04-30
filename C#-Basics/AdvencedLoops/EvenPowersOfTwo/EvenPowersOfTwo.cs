using System;
class EvenPowersOfTwo
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        int number = 1;
        Console.WriteLine(number);
        for (int i = 1; i <= power; i++)
        {
            number *= 2;
            if (i % 2 == 0)
            {
                Console.WriteLine(number);
            }     
        }
    }
}

