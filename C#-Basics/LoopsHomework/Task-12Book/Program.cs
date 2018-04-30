using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n =int.Parse(Console.ReadLine());
            List<int> BinaryNumber= new List<int>();
            while (n > 0 )
	        {

	            int result=  n % 2;
                n = n/2; 
                BinaryNumber.Add(result);
	        }
            BinaryNumber.Reverse();
            foreach (var result in BinaryNumber)
            {
                Console.Write(result);
            }
            Console.WriteLine();

        }
    }

