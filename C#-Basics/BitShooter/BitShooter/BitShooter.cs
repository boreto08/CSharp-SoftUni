using System;

class BitShooter
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            int center = int.Parse(input[0]);
            int size = int.Parse(input[1]);
            if (size == 1)
            {
               num = num & ~(1L << center);
                continue;
            }
            int offset = (size - 1) / 2;
            num = num & ~(1L << center);
            for (int j = 1; j <= offset; j++)
            {
                if (center+ j < 64)
                {
                    num = num & ~(1L << center + j);
                }
            }
            for (int k = 1; k <= offset; k++)
            {
                if (center - k > -1 )
                {
                    num = num & ~(1L << center - k);
                }
            }
        }
         
        int countLeft = 0;
        int countRight = 0;
        for (int i = 0; i < 32; i++)
        {
            long bit = (num >> i) & 1L;
            if (bit == 1)
            {
                countRight++;
            }
        }
        for (int m = 32; m < 64; m++)
        {
            long bitValue = (num >> m) & 1L;
            if (bitValue == 1)
            {
                countLeft++;
            }
        }
        Console.WriteLine("Left "+countLeft);
        Console.WriteLine("Right " + countRight);

    }
}

