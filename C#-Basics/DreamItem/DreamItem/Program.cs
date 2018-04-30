using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\');
        string month = input[0];
        decimal moneyPerHour = decimal.Parse(input[1]);
        int hoursPerDay = int.Parse(input[2]);
        decimal item = decimal.Parse(input[3]);
        decimal salary = 0m;
        int days=0;
        if (month == "Dec" || month == "Oct" || month == "Jan" || month == "Mar" || month == "May" || month == "July" || month == "Aug")
	    {
		  days=21;
	    }
        else if (month == "Feb")
	    {
		 days=18;
	    }
        else if (month == "Nov" || month == "Apr" || month == "June" || month == "Sep")
	    {
            days = 20;
	    }
        salary = days * moneyPerHour * hoursPerDay;
        if (salary>700)
        {
            salary = salary + (salary / 10);
        }
        if (salary>item)
        {
            Console.WriteLine("Money left = {0:f2} leva.",salary-item);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:f2} leva needed.",item-salary);
        }

       
            
          
             
        
   
    }
}

