using System;
class OddEvenPositions
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;


        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;
        

        for (int i = 1; i <= n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += number;
                if (number > evenMax)
                {
                    evenMax = number;
                }
                if (number < evenMin)
                {
                    evenMin = number;
                }
            }
            else
            {
                oddSum += number;
                if (number > oddMax)
                {
                    oddMax = number;
                }
                if (number < oddMin)
                {
                    oddMin = number;
                }
            }
        }

        Console.WriteLine("OddSum {0} oddMin {1} oddMax {2} evenSum {3} evenMin {4} evenMax {5}", 
            oddSum, 
            oddMin == double.MaxValue ? "No" : oddMin.ToString(),
            oddMax == double.MinValue ? "No" : oddMax.ToString(), 
            evenSum, 
            evenMin == double.MaxValue ? "No" : evenMin.ToString(), 
            evenMax == double.MinValue ? "No" : evenMax.ToString());
    }
}

