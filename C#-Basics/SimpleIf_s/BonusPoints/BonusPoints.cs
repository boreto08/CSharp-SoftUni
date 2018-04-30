namespace BonusPoints
{
    using System;
    class BonusPoints
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            if ( n <= 100)
            {
                sum += 5.0;
            }
            else if (n > 100 && n < 1000)
            {
                sum += n * 20 / 100;  //  (20 / 100) == 0.2
            }
            else
            {
                sum += n * 0.1;
            }
            // Bonus points
            if (n % 2 == 0)
            {
                sum += 1.0;
            }
            else if (n % 10 == 5)
            {
                sum += 2.0;
            }
            //Printing
            Console.WriteLine(sum);
            Console.WriteLine(sum + n);

        }
    }
}
