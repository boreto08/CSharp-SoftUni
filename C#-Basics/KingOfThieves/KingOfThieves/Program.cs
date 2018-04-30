using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', n / 2 - i), new string(symbol, n / n + (2*i)));
            }
            int middSymbol=n-2;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', n / n + i),new string(symbol,middSymbol - (2*i)) );
            }
        }
    }

