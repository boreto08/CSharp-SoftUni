using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = 0;
        if (n % 2 == 0)
        {
            stars = 2;
        }
        else
        {
            stars = 1;
        }
        for (int i = 0; i < (n + 1) / 2 ; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2 - i), new string('*',stars + (2*i)));
        }
        for (int j = 0; j < n / 2  ; j++)
        {
            Console.WriteLine("|{0}|",new string('*',n-2));
        }
    }
}

