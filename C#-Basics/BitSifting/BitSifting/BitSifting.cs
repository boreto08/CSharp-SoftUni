using System;
class BitSifting
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        byte times = byte.Parse(Console.ReadLine());
        if (times != 0 )
        {
            for (int i = 0; i < times; i++)
            {
                long sieve = long.Parse(Console.ReadLine());
                num = num ^ sieve;
                num = num & ~sieve;

            }
        }
        
        int count = 0;
        for (int i = 0; i < 63; i++)
        {
            long bit= (num >> i) & 1L;
            if (bit == 1 )
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

