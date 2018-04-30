using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 2;
        bool isCircle = true;
        if ((x*x)+(y*y)<=radius*2)
        {
            Console.WriteLine(isCircle);
        }
        else 
        {
            isCircle = false;
            Console.WriteLine(isCircle);
        }
       
    }
}

