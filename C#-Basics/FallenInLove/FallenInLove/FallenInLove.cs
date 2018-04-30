using System;

class FallenInLove
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsTop = (n * 2) - 2;
        Console.WriteLine("##{0}##{0}##",new string('.',2*n));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("#{1}#{0}#{2}#{0}#{1}#", new string('.', dotsTop - (2 * i)), new string('~', n / n + i), new string('.', 2 + (2* i)));
        }
        Console.WriteLine(".#{0}#{1}#{0}#.",new string('~', n), new string('.', 2*n));
        int dotsMiddle = 2 * n - 2;
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', 3 + 2*i), new string('~', n - 1 - i), new string('.', dotsMiddle-(2*i)));
        }
        Console.WriteLine("{0}####{0}",new string('.',(2 * n)+1));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}##{0}", new string('.', (2 * n) + 2));
        }
    }
}

