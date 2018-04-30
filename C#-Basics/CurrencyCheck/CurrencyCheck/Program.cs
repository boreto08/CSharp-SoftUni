using System;
using System.Linq;

class Program
{
    static void Main()
    {
       
        decimal dollar = 1.5m;
        decimal euro = 1.95m;
        decimal rubla = 0.035m;

        decimal[] values = new decimal[5];
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = decimal.Parse(Console.ReadLine());
          
        }
        values[0] = values[0] * rubla;
        values[1] = values[1] * dollar;
        values[2] = values[2] * euro;
        values[3] = values[3]/2;
        Console.WriteLine("{0:f2}",values.Min());

    }
}
