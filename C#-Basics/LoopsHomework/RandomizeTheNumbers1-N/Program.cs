using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeTheNumbers1_N
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr=new int[n+1];
            Random random=new Random();
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
                
            }
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(random.Next(n+2));
            }
          
        }
    }
}
