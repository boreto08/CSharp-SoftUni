﻿using System;

class Program06ProblemCalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int result = 1;
        if (k<n)
        {
            for (int i = k+1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        


    }
}

