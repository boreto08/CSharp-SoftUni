using System;

    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int numberOfZeroes = 0;
            int divisor = 5;

            while (inputNumber / divisor >= 1)
            {
                numberOfZeroes = numberOfZeroes + (inputNumber / divisor);
                divisor *= 5;
            }
            Console.WriteLine(numberOfZeroes);

        }
    }

