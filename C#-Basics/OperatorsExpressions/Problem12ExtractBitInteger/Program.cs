using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int mask = number >> pos;
        int preparation = mask & 1;
        Console.WriteLine(preparation);
    }
}

