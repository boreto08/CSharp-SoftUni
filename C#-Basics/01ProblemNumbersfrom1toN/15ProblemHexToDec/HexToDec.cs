using System;
using System.Collections.Generic;



class HexToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        long result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += CharToInt(arr[arr.Length - 1 - i]) * (long)Math.Pow(16, i);
        }
        Console.WriteLine(result);
    }

    static long CharToInt(char ch)
    {
        long result = 0;

        if (char.IsDigit(ch))
        {
            result = long.Parse(ch.ToString());
            return result;
        }
        else
        {
            if (ch == 'A')
            {
                return 10L;
            }
            else if (ch == 'B')
            {
                return 11L;
            }
            else if(ch == 'C')
            {
                return 12L;
            }
            else if (ch == 'D')
            {
                return 13L;
            }
            else if (ch == 'E')
            {
                return 14L;
            }
            else
            {
                return 15L;
            }
        }
       
    }
}

