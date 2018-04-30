using System;

class TrailingZeroesinNFactorial
{
    static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        int power= 1;
        int sum = 0;
        while ((num/Math.Pow(5,power)) > 1)
        {
            sum += (int)num / (int)Math.Pow(5, power);
            power++;
        }
        Console.WriteLine(sum);
    }
}

