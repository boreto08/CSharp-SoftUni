using System;
using System.Linq;
class Budget
{
    static void Main()
    {
        decimal  money = decimal .Parse(Console.ReadLine());
        decimal  weekDaysOut = decimal .Parse(Console.ReadLine());
        
        decimal  weekEndsHomeTown = decimal .Parse(Console.ReadLine());
        

        decimal  result = 150m;
        decimal  month = 30m;
        decimal  weekEnds = 4m;
       decimal  normalWeekEnds = weekEnds - weekEndsHomeTown;
        normalWeekEnds *= 2*20m;
        decimal  normalDays = (month - (weekEnds * 2) - weekDaysOut) * 10m;
        
        decimal threePercent= Math.Floor(0.03m*money);
        decimal weekDaysOutExpenses = weekDaysOut * (threePercent + 10);

        result += normalWeekEnds + normalDays + weekDaysOutExpenses;
        if (money>result)
        {
            Console.WriteLine("Yes, leftover {0}.", money - result);
        }
        else if(money==result)
        {
            Console.WriteLine("Exact buget");
        }
        else
	    {
            Console.WriteLine("No, not enough {0}",result-money);
	    }
    }
}

