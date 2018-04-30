using System;

    class ProblemBinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            int[] arr = new int[input.Length];
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(inputArr[i].ToString()); 
            }

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[arr.Length - 1 - i] * (int)Math.Pow(2, i);
            }
            Console.WriteLine(result);
          
        }
    }

