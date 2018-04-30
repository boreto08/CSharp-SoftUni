using System;


    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= row+n-1; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }

