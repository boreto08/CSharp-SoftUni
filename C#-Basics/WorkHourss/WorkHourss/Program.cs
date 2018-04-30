using System;

class Program
{
    static void Main()
    {
        int requiredHours = int.Parse(Console.ReadLine());
        int daysToFinish = int.Parse(Console.ReadLine());
        int percent = int.Parse(Console.ReadLine());

        float actualWork = daysToFinish * 10f/100f;
        actualWork = daysToFinish - actualWork;
        actualWork = actualWork * 12 * (percent/ 100f);
        int result = requiredHours - (int)actualWork;
        if (requiredHours>actualWork)
        {
            Console.WriteLine("No!");
            Console.WriteLine(-result);
        }
        else
        {
            Console.WriteLine("Yes!");
            Console.WriteLine(result*-1);
        }
       


    }
}

