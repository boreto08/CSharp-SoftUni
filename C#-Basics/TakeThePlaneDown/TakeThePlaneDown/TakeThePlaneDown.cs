using System;

    class TakeThePlaneDown
    {
        static void Main()
        {
            int headX = int.Parse(Console.ReadLine());
            int headY = int.Parse(Console.ReadLine());
            int borderDistance = int.Parse(Console.ReadLine());
            int approachingPlanes = int.Parse(Console.ReadLine());
            
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            for (int i = 0; i < approachingPlanes; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());

                if (Math.Pow((planeX - headX), 2) + Math.Pow((planeY - headY), 2) < Math.Pow(borderDistance,2))
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]",planeX,planeY);
                }
            }
        }
    }

