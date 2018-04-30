using System;

class CalculateGCD
{
    static void Main()
    {      
         
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            int swap = a;
            a = b;
            a = swap;
        }
        int reminder = a % b;
        int diff = 0;
        while (reminder > 0 )
        {
             diff =b % reminder;
             b = reminder;
             reminder = diff;
        }
        Console.WriteLine(b);
        


    }
}

