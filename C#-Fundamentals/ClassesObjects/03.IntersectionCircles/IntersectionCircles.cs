using System;
using System.Linq;

namespace _03.IntersectionCircles
{
    class IntersectionCircles
    {
        static void Main()
        {
            int[] argsC1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int c1X = argsC1[0];
            int c1Y = argsC1[1];
            int c1R = argsC1[2];

            Circle c1 = new Circle(c1X, c1Y, c1R);

            int[] argsC2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int c2X = argsC2[0];
            int c2Y = argsC2[1];
            int c2R = argsC2[2];

            Circle c2 = new Circle(c2X, c2Y, c2R);
            bool isCirclesIntersect = isIntersect(c1, c2);
            if (isCirclesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        
        static bool isIntersect(Circle c1, Circle c2)
        {
            int distanceRadius = (int)Math.Sqrt(CalculateDistanceTwoPoints(c1, c2));

            if (distanceRadius <= c1.radius + c2.radius)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static int CalculateDistanceTwoPoints(Circle c1, Circle c2)
        {
            int a = Math.Abs(c1.centerX - c2.centerX);
            int b = Math.Abs(c1.centerY - c2.centerY);

            return (a * a) + (b * b);
        }
    }
}

