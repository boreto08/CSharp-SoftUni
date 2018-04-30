using System;
using System.Numerics;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        if (K >= N || N <= 1 || K <= 1 || N > 100000)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        BigInteger firstFactorial = 1;
        for (int i = N; i > (N - K); i--)
        {
            firstFactorial *= i;
        }
        BigInteger secondFactorial = 1;
        for (int m = K; m > 1; m--)
        {
            secondFactorial *= m;
        }
        BigInteger result = firstFactorial * secondFactorial;
        Console.WriteLine(result);

    }
}

