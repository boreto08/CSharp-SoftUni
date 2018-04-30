using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n-2-(2*i)), new string('.', n+2+(4*i)));
        }
        for (int i = 0; i < n/2; i++)
        {
            if (i>0)
            {
                Console.WriteLine("*{0}*{2}*{1}*{2}*{0}*", new string('.', n - 2-(2*i)), new string('.', n), new string('.', n/n-2+(2*i)));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('.', n - 2), new string('.', n));
            }
        }
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n - 1 - i), new string('.', n+(2*i)));
        }
        Console.WriteLine(new string('*',3*n));
    }
}
