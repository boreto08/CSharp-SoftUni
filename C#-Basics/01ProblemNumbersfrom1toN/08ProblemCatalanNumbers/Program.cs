using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = Factorial(2*n) / (Factorial(n+1) * Factorial(n));
            Console.WriteLine(result);
        }

        static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }


    }

