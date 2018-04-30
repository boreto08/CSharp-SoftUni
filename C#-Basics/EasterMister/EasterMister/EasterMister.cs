using System;

class EasterMister
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int  times = (N*2-4)/4;

        Console.WriteLine("{0}{1}{0}", new string('.', N + 1), new string('#', N - 1));
        if (N< 6)
	    {
		    for (int i = 0; i < (N*2-4)/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', N - 1 - (2 * i)), new string('.', N +1+(4 * i)));
            }
	    }
        else
        {
		    for (int i = 0; i < times; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', N - 1 - (2 * i)), new string('.', N +1+(4 * i)));
            }
            for (int i = 0; i < times; i++)
			{
			    Console.WriteLine(".*{0}*.",new string('.',3*N-3));
			}
        }
        Console.Write(".*");
        for (int i = 0; i < 3*N-3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(".");
            }
            else
            {
                Console.Write("#");
            }
        }
        Console.WriteLine("*.");
        Console.Write(".*");
        for (int i = 0; i < 3 * N - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine("*.");
        int dots = (3 * N + 1) - N - 2;
        if (N < 6)
        {
            for (int i = 0; i < (N * 2 - 4) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', N/N + (2 * i)), new string('.', 3*N-3 - (4 * i)));
            }
        }
        else
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(".*{0}*.", new string('.', 3 * N - 3));
            }
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', N/2 +(2*i)), new string('.', dots- (4*i)));
            }
            
        }
        Console.WriteLine("{0}{1}{0}", new string('.', N + 1), new string('#', N - 1));

        
    }
}

