using System;
using System.Collections.Generic;
using System.Linq;
class SelectionSort
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int min = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j]) // swap items
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }
        }
        Console.WriteLine(string.Join(",",array));

    }
}

