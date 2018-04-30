using System;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}",new string('.',N),new string('*',N));
        for (int i = 0; i < (N/2)-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', N-1-i), new string('.', N+(2*i)));
        }
        Console.WriteLine("{0}{1}{0}", new string('*', (N/2)+1), new string('.', (N*2)-2));
        for (int i = 0; i < (N/2)-2; i++)
        {
            Console.WriteLine("*{0}*",new string('.',(3*N)-2));
        }
        Console.WriteLine("{0}", new string('*', 3 * N));
        for (int i = 0; i < (N/2)-2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{1}*{0}",new string('.',N/2),new string('.',(N/2)-1),new string('.',N-2));
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', N / 2), new string('*', (N / 2) + 1), new string('.', N - 2));
    }
}

