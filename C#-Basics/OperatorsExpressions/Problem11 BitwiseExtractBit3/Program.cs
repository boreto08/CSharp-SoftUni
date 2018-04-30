using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = number >> 3;
        int preparation = mask & 1;
        Console.WriteLine(preparation);

    }
}

