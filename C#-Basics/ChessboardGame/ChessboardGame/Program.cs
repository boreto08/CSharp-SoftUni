using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] input = Console.ReadLine().ToCharArray();
            int[] arr = new int[input.Length];
            int BlackSum = 0;
            int WhiteSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetterOrDigit(input[i]))
                {
                    arr[i] = (int)input[i];
                    if (i % 2 == 0)
                    {
                        if (char.IsUpper(input[i]))
                        {
                            WhiteSum += arr[i];
                        }
                        else
                        {
                            BlackSum += arr[i];
                        }
                    }
                        
                    else
                    {
                        if (char.IsUpper(input[i]))
                        {
                            BlackSum += arr[i];
                        }
                        else
                        {
                            WhiteSum += arr[i];
                        }
                    }
                }
               
            }
            if (BlackSum>WhiteSum)
            {
                Console.WriteLine("the winner is: black team");
                Console.WriteLine(BlackSum-WhiteSum);
            }
            else if (WhiteSum>BlackSum)
            {
                Console.WriteLine("the winner is: white team");
                Console.WriteLine(WhiteSum - BlackSum);
            }
            else
            {
                Console.WriteLine("equal result: " +BlackSum);
            }
        }
    }

