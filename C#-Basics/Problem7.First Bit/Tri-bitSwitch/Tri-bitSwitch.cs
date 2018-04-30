using System;

    class TriBitSwitch
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(64, '0'));
            
            long mask = 7L << times;
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(64, '0'));
           
            long result = n ^ mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));
            
            Console.WriteLine(result);
        }
    }

