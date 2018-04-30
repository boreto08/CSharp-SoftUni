using System;

class Program
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        int gravitationOnMoon = 17;//percent
        double weightOnMoon = (weight * gravitationOnMoon)/100;
        Console.WriteLine(weightOnMoon);

        
    }
}

