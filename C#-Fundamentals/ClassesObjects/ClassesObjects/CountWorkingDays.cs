using System;
using System.Globalization;

class CountWorkingDays
{
    static void Main()
    {
      
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        int count = 0;
        DateTime[] holidays = new DateTime[]
        {   new DateTime(startDate.Year,01,01),
            new DateTime(startDate.Year,03,03),
            new DateTime(startDate.Year,05,01),
            new DateTime(startDate.Year,05,06),
            new DateTime(startDate.Year,05,24),
            new DateTime(startDate.Year,09,06),
            new DateTime(startDate.Year,09,22),
            new DateTime(startDate.Year,11,01),
            new DateTime(startDate.Year,12,24),
            new DateTime(startDate.Year,12,25),
            new DateTime(startDate.Year,12,26)  };
        bool holidayFound = false;

        for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
        {
            
            foreach (var date in holidays)
            {
                if (date.CompareTo(i) == 0)
                {
                    holidayFound = true;
                    break;
                }
            }
            if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday || holidayFound == true)
            {
                holidayFound = false;
                continue;
            }
            count++;

        }

        Console.WriteLine(count);

    }
}

