using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int numberOfSets = int.Parse(Console.ReadLine());
            int sizeOfArrays = int.Parse(Console.ReadLine());
            string OddEven = Console.ReadLine();
            int maxNumber = 0;
            
            

            for (int i = 0; i < numberOfSets ; i++)
            {
                int[] arr = new int[sizeOfArrays];
                for (int k = 0; k < sizeOfArrays; k++)
                {
                    arr[k] = int.Parse(Console.ReadLine());
                }
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (OddEven=="odd")
                    {
                        
                    }
                }
            }
        }
    }

