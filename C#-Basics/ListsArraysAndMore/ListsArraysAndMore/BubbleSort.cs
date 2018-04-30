using System;
using System.Linq;

class BubbleSort
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        bool swaped = true;
        do
        {
            swaped = false;
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] > input[i+1])
                {
                    int buffer = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = buffer;

                    swaped = true;

                }
            }
        } while (swaped);
        Console.WriteLine(String.Join(",",input));
    }
}

