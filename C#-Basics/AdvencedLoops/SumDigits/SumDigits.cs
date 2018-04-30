using System;

class SumDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int result = 0;
        while (number > 0)
        {
            int reminder = number % 10;
            result += reminder;
            number /= 10;
        }
        Console.WriteLine(result);
    }
}

