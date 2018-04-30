using System;

    class Problem07Calculate
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;

            for (int i = n-k+1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            Console.WriteLine(factorialN/factorialK);
        }
    }

