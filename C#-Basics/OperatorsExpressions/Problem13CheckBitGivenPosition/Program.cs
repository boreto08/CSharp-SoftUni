using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        bool isOne = true;
        int mask = number >> pos;
        int preparation = mask & 1;
        if (preparation != 1)
        {
            isOne = false;
        }
        Console.WriteLine(isOne);
    }
}

