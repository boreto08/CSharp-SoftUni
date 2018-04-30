using System;

    class _2dRectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Abs(x1 - x2);
            double height = Math.Abs(y2 - y1);

            double area = height * width;
            double perimeter = 2 * (height + width);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
           

        }
    }

