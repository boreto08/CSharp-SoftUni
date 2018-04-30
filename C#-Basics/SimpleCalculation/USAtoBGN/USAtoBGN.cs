using System;

    class USAtoBGN
    {
        static void Main()
        {
            //1 USD = 1.79549 BGN
            double dollars = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2} BGN",dollars * 1.79549);
        }
    }

