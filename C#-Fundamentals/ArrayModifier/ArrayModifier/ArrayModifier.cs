using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class ArrayModifier
    {
        static void Main()
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var args = input.Split();
                var command = args[0];
                int elementOne = 0;
                int elementTwo = 0;
                switch (command)
                {
                    case "swap":
                         elementOne = int.Parse(args[1]);
                         elementTwo = int.Parse(args[2]);
                        SwapElements(arr, elementOne, elementTwo);
                        break;
                    case "multiply":
                         elementOne = int.Parse(args[1]);
                         elementTwo = int.Parse(args[2]);
                        MultiplyElements(arr, elementOne, elementTwo);
                        break;
                    case "decrease":
                        DecreaseAll(arr);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",arr));

        }

        private static void DecreaseAll(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] - 1;
            }
        }

        private static void MultiplyElements(long[] arr, int elementOne, int elementTwo)
        {
            long product = arr[elementOne] * arr[elementTwo];
            arr[elementOne] = product;
        }

        private static void SwapElements(long[] arr, int indexOne, int indexTwo)
        {
            long buffer = arr[indexOne];
            arr[indexOne] = arr[indexTwo];
            arr[indexTwo] = buffer;
        }
    }
}
