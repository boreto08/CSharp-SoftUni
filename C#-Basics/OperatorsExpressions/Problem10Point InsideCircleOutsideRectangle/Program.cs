using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool isCircle = true;
        if (Math.Pow(x-1,2) + Math.Pow(y-1,2) <= radius*radius)
        {
            Console.WriteLine(isCircle);
        }
        else
        {
            isCircle = false;
            Console.WriteLine(isCircle);
        }
        bool isOut = false;
        if ((x <= -1 || x >=5) || (y>= 1 || y <= -1) )
        {
            isOut = true;
        }
        if (isCircle== true && isOut==true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

