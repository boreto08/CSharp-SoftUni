﻿using System;

class FitBoxInBox
{
    static void Main()
    {
        int w1 = int.Parse(Console.ReadLine());
        int h1 = int.Parse(Console.ReadLine());
        int d1 = int.Parse(Console.ReadLine());

        int w2 = int.Parse(Console.ReadLine());
        int h2 = int.Parse(Console.ReadLine());
        int d2 = int.Parse(Console.ReadLine());

        if (w1 + h1 + d1 > w2+ h2 +d2)
        {
            int buferW1 = w1;
            int buferH1 = h1;
            int buferD1 = d1;

            w1 = w2;
            h1 = h2;
            d1 = d2;

            w2 = buferW1;
            h2 = buferH1;
            d2 = buferD1;
        }

        if ((w1 < w2) && (h1 < h2) && (d1 < d2))
        {
            Console.WriteLine("({0},{1},{2})<({3},{4},{5})",w1,h1,d1,w2,h2,d2);
        }
        if ((w1 < w2) && (h1 < d2) && (d1 < h2))
        {
            Console.WriteLine("({0},{1},{2})<({3},{4},{5})", w1, h1, d1, w2, d2, h2);
        }

        if (w1 < h2 && h1 < d2 && d1 < w2)
        {
           Console.WriteLine("({0},{1},{2})<({3},{4},{5})",w1,h1,d1,h2,d2,w2);
        }
        if (w1 < h2 && h1 < w2 && d1 < d2)
        {
            Console.WriteLine("({0},{1},{2})<({3},{4},{5})", w1, h1, d1, h2, w2, d2);
        }

        if (w1 < d2 && h1 < w2 && d1 < h2)
        {
            Console.WriteLine("({0},{1},{2})<({3},{4},{5})", w1, h1, d1, d2, w2, h2);
        }
        if (w1 < d2 && h1 < h2 && d1 < w2)
        {
            Console.WriteLine("({0},{1},{2})<({3},{4},{5})", w1, h1, d1, d2, h2, w2);
        }

    }
}

