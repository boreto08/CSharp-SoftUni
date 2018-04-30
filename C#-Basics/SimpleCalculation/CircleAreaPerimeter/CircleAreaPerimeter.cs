using System;

class CircleAreaPerimeter
{
    static void Main()
    {
        //CircleAreaPerimeter
        //•	area = Math.PI * r * r
        //•	perimeter = 2 * Math.PI * r

        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = {0}",r*r*Math.PI);
        Console.WriteLine("Perimeter = {0}", 2.0 * Math.PI * r);

    }
}

