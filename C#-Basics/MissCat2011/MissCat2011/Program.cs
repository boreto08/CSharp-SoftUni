using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        int[] cats = new int[11];

        for (int i = 0; i < N; i++)
        {
            int mark=int.Parse(Console.ReadLine());

            cats[mark]++;
        }
        int max = 0;
        int result = 0;
        for (int i = 0; i < cats.Length; i++)
        {
            int currentValue = cats[i];

            if (max<currentValue)
            {
                max = currentValue;
                result = i;
            }
        }
        Console.WriteLine(result);
    }
}

