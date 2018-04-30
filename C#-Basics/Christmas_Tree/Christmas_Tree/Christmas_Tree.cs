using System;

class Christmas_Tree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < (n/2)+1 ; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', n - i), new string('^', n / n + (2 * i)));
        }
        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('\'', n - i -1), new string('^', 3 + (2 * i)));
        }
        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}| |{0}", new string('\'', n  - 1));
        }
        Console.WriteLine("{0}",new string('-',(n*2)+1));
    }
}

