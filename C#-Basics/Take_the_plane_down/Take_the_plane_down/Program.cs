using System;

    class Program
    {
        static void Main()
        {
            int headquarterX = int.Parse(Console.ReadLine());
            int headquarterY = int.Parse(Console.ReadLine());
            int headquarterR = int.Parse(Console.ReadLine());
            int comingPlanes = int.Parse(Console.ReadLine());
            for (int i = 0; i < comingPlanes; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());
                int leftPart = (int)Math.Pow((planeX -headquarterX),2) + (int)Math.Pow((planeY -headquarterY),2);
                int rightPart = (int)Math.Pow(headquarterR, 2);
                if (leftPart<rightPart)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]",planeX,planeY);
                }
            }
        }
    }

