using System;

class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= n; i++)
        {
            sum += Factorial(i) / Math.Pow(x, i);
        }
        Console.WriteLine("{0:f5}",sum);
    }

    static double Factorial(int num)
    {
        double factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        return factorial;

    }
}

