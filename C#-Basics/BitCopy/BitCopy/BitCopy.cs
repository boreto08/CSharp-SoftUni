using System;

class BitCopy
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int result = 0;
        int changeBitPos = 2;
        int mask = 1 << pos;
        int nAndMask = number & mask;
        int bit = nAndMask >> pos;

        if (bit == 0)
        {
            mask = ~(1 << changeBitPos);       
            result = number & mask;      
        }
        else
        {
             mask = 1 << changeBitPos;         
            result = number | mask;      
        }
        Console.WriteLine(result);


    }
}

