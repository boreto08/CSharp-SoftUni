using System;

class SummertimeForProgrammers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("{1}{0}{1}",new string('*',N+1),new string(' ',((N*2)-(N+1))/2));
        for (int i = 0; i < N/2; i++)
        {
          Console.WriteLine("{1}*{0}*{1}",new string(' ',N+1-2 ),new string(' ',((N*2)-(N+1))/2));  
        }
        for (int i = 0; i < N / 2; i++)
        {
            Console.WriteLine("{1}*{0}*{1}", new string(' ', N + 1 - 2+(2*i)), new string(' ', ((N * 2) - (N + 1)) / 2 - i));
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("*{0}*",new string('.',N*2-2));
        }
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("*{0}*", new string('@', N * 2 - 2));
        }
        Console.WriteLine(new string('*',2*N));
        
    }
}

