using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\\{0}/",new string('*',n-2));
            for (int i = 1; i <= n/2-1; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('.', i), new string('*', n-2-(2*i)));
            }
            if (n<12)
            {
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', ((n / 2) - 1)));
                }
                Console.WriteLine("{0}", new string('-', n));
            }
            else
            {
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', ((n / 2) - 1)));
                }
                for (int i = 0; i < n/n+1; i++)
                {
                    Console.WriteLine("{0}", new string('-', n));
                }
            }
            
        }
    }

