using System;

class InchToCm
{
    static void Main()
    {
        Console.Write("inches = ");
        double inches = double.Parse(Console.ReadLine());
        Console.WriteLine("Centimeters = {0}", inches * 2.54);
    }
}

