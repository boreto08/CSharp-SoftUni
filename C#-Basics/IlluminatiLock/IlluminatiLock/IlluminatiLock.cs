using System;

class IlluminatiLock
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n), new string('.', n));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}##{2}#{1}#{2}##{0}", new string('.', n - 2 - (2 * i)), new string('.', n-2), new string('.', 2*i));
        }
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}##{2}#{1}#{2}##{0}", new string('.', n/n + (2 * i)), new string('.', n-2), new string('.', n-3 -(2*i)));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n), new string('.', n));

    }
}

