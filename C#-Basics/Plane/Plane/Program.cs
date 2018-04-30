using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int dotsBefore = 0;
        int dotsMiddle = 0;
        Console.WriteLine("{0}*{0}", new string('.', (3 * N - 1) / 2));
        for (int i = 0; i < N/2+1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (3 * N - 3) / 2 - i), new string('.', 1 + (2 * i)));
        }
        dotsMiddle = N + 2;
        dotsBefore = N - 2;

        for (int i = 0; i < N / 2 ; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotsBefore), new string('.', dotsMiddle));
            dotsBefore-=2;
            dotsMiddle += 4;
        }
        for (int i = 0; i < N / 2; i++)
        {
            if (i > 0)
            {
                Console.WriteLine("*{0}*{2}*{1}*{2}*{0}*", new string('.', N - 2 - (2 * i)), new string('.', N), new string('.', N / N - 2 + (2 * i)));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('.', N - 2), new string('.', N));
            }
        }
        for (int i = 0; i < N - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', N - 1 - i), new string('.', N+ (2 * i)));
        }
        Console.WriteLine(new string('*', 3 * N));
        
    }
}

