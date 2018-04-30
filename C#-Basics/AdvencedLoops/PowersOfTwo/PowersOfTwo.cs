using System;
class PowersOfTwo
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        int number = 1;
        Console.WriteLine(number);
        for (int i = 0; i < power; i++)
        {
            number *= 2;
            Console.WriteLine(number);
        }
    }
}

