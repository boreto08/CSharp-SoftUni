using System;

class PyramidOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write(count++ + " ");
                if (count > n)
                {
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine();
        }
        
    }
}

