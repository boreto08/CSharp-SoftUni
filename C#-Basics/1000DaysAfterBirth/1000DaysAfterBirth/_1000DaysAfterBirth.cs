using System;
using System.Globalization;

class _1000DaysAfterBirth
{
    static void Main()
    {
        string input = Console.ReadLine();
         CultureInfo provider = CultureInfo.InvariantCulture;
         DateTime birth = DateTime.ParseExact(input, "dd-MM-yyyy", provider);
         DateTime  After = birth.AddDays(999);
         Console.WriteLine("{0}-{1}-{2}", After.Day.ToString().PadLeft(2, '0'), After.Month.ToString().PadLeft(2, '0'), After.Year);
    }
}

