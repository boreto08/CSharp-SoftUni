using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if ( number == 0 )
        {
            Console.WriteLine(0);
        }
        else
        {
            List<int> result = new List<int>();
            int binaryNumber = 0;
            while (number > 0)
            {
                binaryNumber = number % 2;
                number /= 2;
                result.Add(binaryNumber);
            }
            result.Reverse();
            foreach (var num in result)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
        

    }
}

