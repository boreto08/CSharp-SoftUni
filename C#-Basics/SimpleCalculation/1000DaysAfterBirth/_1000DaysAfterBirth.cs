using System;
using System.Globalization;

class _1000DaysAfterBirth
{
    static void Main()
    {
         string input = Console.ReadLine();
         //CultureInfo BG = new CultureInfo("bg-BG");
         DateTime birthday = DateTime.Parse(input);
         

         DateTime after1000Days = birthday.AddDays(999);
        Console.WriteLine(after1000Days.ToShortDateString());
        
    }
}

