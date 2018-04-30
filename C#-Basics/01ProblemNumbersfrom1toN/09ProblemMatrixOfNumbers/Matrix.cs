using System;

    class Matrix
    {
        static void Main()
        {
            Console.Write("Type number:");
            int N = int.Parse(Console.ReadLine());
            if (N > 0 && N <= 20)
            {
                for (int row = 1; row <= N; row++)
                {

                    for (int col = row; col <= N + row - 1; col++)
                    {
                        Console.Write(col);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }

