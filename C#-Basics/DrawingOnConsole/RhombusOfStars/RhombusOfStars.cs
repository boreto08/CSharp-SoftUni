using System;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}",new string(' ',n-i));
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        for (int k = 1; k <= n-1; k++)
        {
            Console.Write("{0}",new string(' ',k));
            for (int j = n-1; j >= k; j--)
            {
                Console.Write("*");
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

}

