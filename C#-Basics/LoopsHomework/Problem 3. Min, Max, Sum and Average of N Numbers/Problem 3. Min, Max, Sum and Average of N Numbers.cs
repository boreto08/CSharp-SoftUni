using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] sequance = new int[n];
            for (int i = 0; i < sequance.Length; i++)
            {
                sequance[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sequance.Min());
            Console.WriteLine(sequance.Max());
            Console.WriteLine(sequance.Sum());
            Console.WriteLine(sequance.Average());
        }
    }
}
