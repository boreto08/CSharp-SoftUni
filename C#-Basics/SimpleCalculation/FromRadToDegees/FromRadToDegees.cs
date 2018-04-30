using System;

class FromRadToDegees
{
    static void Main()
    {
        //57.3= 1rad

        double rad = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Round(rad*57.3));
    }
}

