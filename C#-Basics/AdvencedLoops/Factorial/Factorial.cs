using System;

class Factorial
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}

