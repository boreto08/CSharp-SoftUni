using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class OddOrEven
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] str = input.Split();
            int[] arr = new int[str.Length];
            int oddProduct = 1;
            int evenProduct = 1;


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i+1) % 2 == 0 )
                {
                    evenProduct *= arr[i];
                }
                else
                {
                    
                    oddProduct *= arr[i];
                }
            }
            if (oddProduct==evenProduct)
            {
                Console.WriteLine( "yes");
                Console.WriteLine(evenProduct);

            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine(evenProduct);
                Console.WriteLine(oddProduct);
            }

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] convertedItems = Array.ConvertAll<string, int>(str, int.Parse);
            //foreach (var item in convertedItems)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }

