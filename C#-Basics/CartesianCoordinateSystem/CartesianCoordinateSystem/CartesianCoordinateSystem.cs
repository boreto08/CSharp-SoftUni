using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        long X = long.Parse(Console.ReadLine());
        long Y = long.Parse(Console.ReadLine());

        if (X==0 && Y==0)
        {
            Console.WriteLine(0);
        }
        else if(X == 0 && Y > 0)
        {
            Console.WriteLine(5);
        }
        else if (X > 0 && Y == 0)
        {
            Console.WriteLine(6);
        }
         else if (X > 0 && Y > 0)
        {
            Console.WriteLine(1);
        }
         else if (X < 0 && Y > 0)
        {
            Console.WriteLine(2);
        }
        else if (X < 0 && Y < 0)
        {
            Console.WriteLine(3);
        }
         else if (X > 0 && Y < 0)
        {
            Console.WriteLine(4);
        }
    }
}

