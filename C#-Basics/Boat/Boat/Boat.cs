using System;

class Boat
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N/2 +1; i++)
        {
            Console.WriteLine("{0}{1}{2}",new string('.', N - 1 -(2*i)),new string('*', N/N +(2*i)),new string('.', N));
        }
        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', N - (N-2) + (2 * i)), new string('*', N -2 - (2 * i)), new string('.', N));
        }
        Console.WriteLine(new string('*',2*N));
        for (int i = 0; i <(N-1)/2-1; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.', N/N +i),new string('*', 2*N-2-(2*i)));
        }
    }
}

