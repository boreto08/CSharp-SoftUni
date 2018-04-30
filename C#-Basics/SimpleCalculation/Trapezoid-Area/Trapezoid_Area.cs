using System;

    class Trapezoid_Area
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Тrapezoid area = {0}",((a+b)*h)/2);

        }
    }

