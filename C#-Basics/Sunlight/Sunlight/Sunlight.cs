using System;

    class Sunlight
    {
        static void Main()
        {
            int n =int.Parse(Console.ReadLine());
            int dots = ((n * 2 + n) - 5) / 2;
            Console.WriteLine("{0}*{0}",new string('.',((n*2) + (n-1))/2));
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',n / n+ i),new string('.',dots-i));
            }
            int rows = ((n*2+n)/4)-1;
            for (int i = 0; i < rows ; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            Console.WriteLine("{0}", new string('*', n * 2 + n ));
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
            }
            int secDots = rows;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n -1 - i), new string('.', rows + i));
            }
            Console.WriteLine("{0}*{0}", new string('.', ((n * 2) + (n - 1)) / 2));
        }
    }

