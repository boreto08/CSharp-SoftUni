using System;

class Program
{
    static void Main()
    {   //..#.#...#.#..
        //.#...#.#...#.
        int n = int.Parse(Console.ReadLine());
        char innerSymbol = char.Parse(Console.ReadLine());
        char outLineSymbol = char.Parse(Console.ReadLine());
        Console.WriteLine("{0}{2}{1}{2}{0}", new string(innerSymbol, n), new string(innerSymbol, n * 2 - 1),new string(outLineSymbol,n/n));
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(innerSymbol, n - 1 - i), new string(innerSymbol, n / n + (2 * i)), new string(innerSymbol, (n * 2 - 3) - (2 * i)), new string(outLineSymbol, n / n));
        }
        Console.WriteLine("{1}{0}{1}{0}{1}", new string(innerSymbol, n * 2 - 1), new string(outLineSymbol, n / n));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(innerSymbol, n / n + i), new string(innerSymbol, (n * 2 - 3) - (2 * i)), new string(innerSymbol, n / n + (2 * i)), new string(outLineSymbol, n / n));
        }

        Console.WriteLine("{0}{2}{1}{2}{0}", new string(innerSymbol, n), new string(innerSymbol, n * 2 - 1), new string(outLineSymbol, n / n));

        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(innerSymbol, n - 1 - i), new string(innerSymbol, n / n + (2 * i)), new string(innerSymbol, (n * 2 - 3) - (2 * i)), new string(outLineSymbol, n / n));
        }
        Console.WriteLine("{1}{0}{1}{0}{1}", new string(innerSymbol, n * 2 - 1), new string(outLineSymbol, n / n));
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(innerSymbol, n / n + i), new string(innerSymbol, (n * 2 - 3) - (2 * i)), new string(innerSymbol, n / n + (2 * i)), new string(outLineSymbol, n / n));
        }

        Console.WriteLine("{0}{2}{1}{2}{0}", new string(innerSymbol, n), new string(innerSymbol, n * 2 - 1), new string(outLineSymbol, n / n));
    }
}
