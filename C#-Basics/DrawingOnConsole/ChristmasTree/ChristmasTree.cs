using System;

class ChristmasTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write("{0}", new string(' ', n +1));
        Console.WriteLine("|");
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}",new string(' ', n - 1 - i));
            Console.Write("{0}",new string('*', i + 1));
            Console.Write(" | ");
            Console.Write("{0}", new string('*', i + 1));
            Console.WriteLine();
        }
    }
}

