using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08FromBook
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftSide = 1;
            int rightFactorialPart2=0;
            int rightFactorialPart1 = 1;
            int rightSide=0;
            for (int i = 1; i <= 2*n; i++)
            {
                leftSide *= i;
            }
            for (int i = 1; i <= n+1; i++)
            {
               rightFactorialPart1*=i; 
            }
            
            rightFactorialPart2= rightFactorialPart1/(n+1);

            rightSide = rightFactorialPart1 * rightFactorialPart2;
                Console.WriteLine(leftSide/rightSide);
        }
    }
}
