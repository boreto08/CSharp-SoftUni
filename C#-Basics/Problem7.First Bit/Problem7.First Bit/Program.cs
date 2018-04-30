using System;

    class BitDestroyer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            int mask = n & ~(1 << times);
            Console.WriteLine(mask);

        }
    }

