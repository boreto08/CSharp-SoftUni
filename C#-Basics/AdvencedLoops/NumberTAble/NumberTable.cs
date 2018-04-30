using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 0;
        int lastElement = n;
        
        for (int row = 0; row < n; row++)
        {
            int substract = 1;
            for (int col = 0; col < n; col++)
            {
                if (row > 0)
                {
                    if (  col >= lastElement - row)
                    {
                        
                        num = 2 * n - n - substract;
                        substract++;
                    }
                    else
                    {
                        num = row + col + 1;
                    }
                    
                }
                else
                {
                    num = row + col + 1;
                }
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

