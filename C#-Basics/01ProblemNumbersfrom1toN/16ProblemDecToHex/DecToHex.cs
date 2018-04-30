using System;
using System.Collections.Generic;

class DecToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        List<string> result = new List<string>();
        long hexNum = 0;
        while (input > 0 )
        {
            hexNum = input % 16L;
            input /= 16L;
            if (hexNum > 9)
            {
                result.Add(ConvertToString(hexNum));
            }
            else
            {
                result.Add(hexNum.ToString());
            }
        }
        result.Reverse();
        foreach (var num in result)
        {
            Console.Write(num);
        }
        Console.WriteLine();

    }
    static string ConvertToString(long num)
    {
        if (num == 10)
        {
            return "A";
        }
        else if (num == 11)
        {
            return "B";
        }
        else if (num == 12)
        {
            return "C";
        }
        else if (num == 13)
        {
            return "D";
        }
        else if (num == 14)
        {
            return "E";
        }
        else
        {
            return "F";
        }
    }
}

