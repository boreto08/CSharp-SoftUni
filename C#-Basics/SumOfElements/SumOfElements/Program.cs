using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');

        long max = long.MinValue;
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            long element = long.Parse(numbers[i]);
            sum = sum + element;
            if (element > max)
            {
                max = element;
            }
        }

        if (sum == 2 * max)
        {
            Console.WriteLine("Yes, sum=" + max);
        }
        else
        {
            long diff = Math.Abs(sum - 2 * max);
            Console.WriteLine("No, diff=" + diff);
        }

    }
}

