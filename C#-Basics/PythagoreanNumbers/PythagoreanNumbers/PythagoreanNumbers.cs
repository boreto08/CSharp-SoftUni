using System;

class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        bool noNumbers = true;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int c = 0; c < arr.Length; c++)
        {
            for (int b = 0; b < arr.Length; b++)
            {
                for (int a = 0; a < arr.Length; a++)
                {
                    if (arr[a] <= arr[b])
                    {
                        if (arr[a]*arr[a] + arr[b]*arr[b] == arr[c]*arr[c])
                        {
                            noNumbers = false;
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", arr[a], arr[b], arr[c]);
                        }
                    }
                }
            }
        }
        if (noNumbers)
        {
            Console.WriteLine("No!");
        }
    }
}

