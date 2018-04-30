using System;
using System.Collections.Generic;

class BinaryDigitsCount
{
    static void Main()
    {
        int B = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            uint num = uint.Parse(Console.ReadLine());
            int bitValue;
            if (B == 1)
            {
                for (int j = 0; j < 32; j++)
                {
                    bitValue = (int)(num >> j) & 1;
                
                        if (bitValue == 1)
                        {
                            count++;
                        }
                }  
            }
            else
            {
                int lastBit = 0;
                for (int k = 32 - 1; k >= 0; k--)
                {
                    int mostLeftOne = (int)(num >> k) & 1;
                    if (mostLeftOne == 1)
                    {
                        lastBit = k;
                        break;
                    }
                }

                for (int t = 0; t < lastBit; t++)
                {
                    bitValue = (int)(num >> t) & 1;
                    if (bitValue == 0)
                    {
                        count++;
                    }
                }
                
                
            }
            list.Add(count);
            count = 0;   
            
        }
        Console.WriteLine(string.Join(" ", list.ToArray()));
    }
}

