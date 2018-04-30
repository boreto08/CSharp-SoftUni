using System;


    class Program
    {
        static void Main()
        {
            string num = Console.ReadLine();

            char[] a = num.ToCharArray();

            int sum = 0;
            Array.Reverse(a);
            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] == '1')
                    sum = sum + ((int)Math.Pow(2, j));
            }
            Console.WriteLine(sum);
        }
    }
