namespace ConvertMetric
{
    using System;

    class ConvertMetric
    {
        //1 meter (m)	1000 millimeters (mm)
        //1 meter (m)	100 centimeters (cm)
        //1 meter (m)	0.000621371192 miles (mi)
        //1 meter (m)	39.3700787 inches (in)
        //1 meter (m)	0.001 kilometers (km)
        //1 meter (m)	3.2808399 feet (ft)
        //1 meter (m)	1.0936133 yards (yd)

        static void Main()
        {
            double size = double.Parse(Console.ReadLine());
            string unitFrom = Console.ReadLine();
            string unitTo = Console.ReadLine();

            double meters = ConvertToMeters(size, unitFrom);
            double result = ConvertToUnit(meters, unitTo);
            Console.WriteLine(result +" "+unitTo);
            

        }

        static double ConvertToMeters(double size,string unit)
        {
            double result = 0.0;
            switch (unit)
            {
                case "mm": return result = size / 1000;
                case "cm": return result = size / 100;
                case "mi": return result = size / 0.000621371192;
                case "in": return result = size / 39.3700787;
                case "km": return result = size / 0.001;
                case "ft": return result = size / 3.2808399;
                case "yd": return result = size / 1.0936133;
                case "m": return size;
                default: return 0;
            }
        }
        static double ConvertToUnit(double meters, string unit)
        {
            double result = 0.0;
            switch (unit)
            {
                case "m": return result = meters * 1;
                case "mm": return result = meters * 1000;
                case "cm": return result = meters * 100;
                case "mi": return result = meters * 0.000621371192;
                case "in": return result = meters * 39.3700787;
                case "km": return result = meters * 0.001;
                case "ft": return result = meters * 3.2808399;
                case "yd": return result = meters * 1.0936133;
                default: return 0;
            }
        }
    }
}
