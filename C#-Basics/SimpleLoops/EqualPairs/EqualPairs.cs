using System;
using System.Collections.Generic;
using System.Linq;
class EqualPairs
{
    static void Main()
    {
        int pairs = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for (int i = 0; i < pairs; i++)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            list.Add(numOne + numTwo);
        }

        List<int> ifOne = list.Distinct().ToList();
        if (ifOne.Count == 1)
        {
            Console.WriteLine("Yes, value={0}",ifOne[0]);
        }
        else
	    {
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
			{
			    if (list[i] < min)
	            {
		            min = list[i];
	            }
                if (list[i] > max)
	            {
		            max = list[i];
	            }
			}
            Console.WriteLine("No, maxdiff={0}",max - min);
	    }

    }
}

