using System;
using System.Collections.Generic;
using System.Linq;
class CategorizeNumberFindMinMaxAverage
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();
        int number;
        double floatNum;


        for (int i = 0; i < input.Length; i++)
        {
            if (int.TryParse(input[i],out number)== true)
            {
                intList.Add(number);
            }
            else if (double.TryParse(input[i], out floatNum) == true)
	        {
                if (floatNum == Math.Round(floatNum))
                {
                    intList.Add(int.Parse(floatNum.ToString()));
                }
                else
                {
                    doubleList.Add(floatNum);
                }
                
	        }
        }
        int intMax = intList.Max();
        int intMin = intList.Min();
        double intAverge = intList.Average();
        int intSum = intList.Sum();

        double doubleMin = doubleList.Min();
        double doubleMax = doubleList.Max();
        double doubleAverage = doubleList.Average();
        double doubleSum = doubleList.Sum();

        Console.Write("[");
        Console.Write(String.Join(", ",doubleList.ToArray()));
        Console.WriteLine(" ] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", doubleMin, doubleMax,doubleSum,doubleAverage);

         
        Console.WriteLine("[" + String.Join(", ",intList.ToArray()) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}",intMin,intMax,intSum,intAverge );



    }
}

