using System;

class sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        
        for (int i = 0; i < n-2; i++)
        {
            if ((n - 1) / 2 - 1 == i)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string('|', n));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string(' ', n));
            } 
        }
        Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
    }
}

