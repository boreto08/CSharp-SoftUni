using System;

class CelsiusToFahrenheit
{
    static void Main()
    {

        //°C  x  9/5 + 32 = °F

        double c = double.Parse(Console.ReadLine());

        double toCelsius = c * 1.8 + 32;
        Console.WriteLine("{0}",toCelsius);

    }
}

