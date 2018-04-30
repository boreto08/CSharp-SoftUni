using System;

class BitSwap
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        long mask = 1L << 3L;        
        long nAndMask = n & mask;  
        long bit3 = nAndMask >> 3L;

        if (bit3 == 0)
        {
            mask = ~(1L << 24L);
             n &= mask;
        }
        else
        {
            mask = 1L << 24L;
            n |= mask;
        }
        
         mask = 1L << 24L;        
         nAndMask = n & mask;  
        int bit24 = nAndMask >> 24L;
        if (bit24 == 0)
        {
            mask = ~(1L << 3L);
            n &= mask;
        }
        else
        {
            mask = 1L << 3L;
            n |= mask;
        }
        Console.WriteLine(n);

    }
}

