using System;
using System.Collections.Generic;
using System.Linq;

class SequencesEqualStrings
{
    static void Main()
    {

        List<string> input = Console.ReadLine().Split(' ').ToList();
        List<string> distincted = input.Distinct().ToList();

        for (int i = 0; i < distincted.Count; i++)
        {
            for (int d = 0; d < input.Count; d++)
            {
                if (distincted[i] == input[d])
                {
                    Console.Write("{0} ", input[d]);
                }
            }
            Console.WriteLine();
        }
    }
}

