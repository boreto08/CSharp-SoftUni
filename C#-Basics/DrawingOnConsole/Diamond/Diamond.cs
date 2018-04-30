using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if (n == 1 )
        {
            Console.WriteLine("*");
        }
        else if (n == 2 )
        {
            Console.WriteLine("**");
        }
        else if (n > 2 && n % 2 == 0)
        {
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string('-',(n-2)/2-i),new string('-',2*i));
            }
            for (int i = 0; i < n/2 -1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-',1+i), new string('-',n-4-(2*i)));
            }
        }
        else
        {
            Console.WriteLine("{0}*{0}",new string('-',(n - 1) / 2 ));
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string ('-',(n - 2) / 2 - i ),new string ('-',1+(2*i)));
            }
            if (n - 2 - (n/2) != 0)
            {
                for (int i = 0; i < n - 2 - (n/2); i++)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', 1 + i), new string('-', n-4 -(2*i)));
                }
            }
            Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
        }
    }
}

