﻿using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{1}*{0}",new string('.',n/2),new string('.',2*n-3));
        for (int i = 0; i < n/2+1; i++)
        {
            Console.WriteLine("{0}{1}{2}*{3}*{2}{1}{0}");
        }
    }
}

