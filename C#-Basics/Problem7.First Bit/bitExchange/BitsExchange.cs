using System;

    class BitsExchange
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int lo = num & 0x00000038; // get bits 3-5
            int hi = num & 0x07000000; // get bits 24-26
            num &= ~0x07000038; // clear bits 3-5 and 24-26
            num |= lo << 21; // put bits 3-5 in 24-26
            num |= hi >> 21; // put bits 24-26 in 3-5
            Console.WriteLine(num);
        }
    }

