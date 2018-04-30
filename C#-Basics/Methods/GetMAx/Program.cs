using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMAx
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;
            int result=GetMaxx(num1,num2);
            Console.WriteLine(result);
        }

        static int GetMaxx(int firstNum, int secNumber)
        {
            if (firstNum>secNumber)
            {
                return firstNum;
            }
            else if(secNumber>firstNum)
	        {
                return secNumber;
	        }
            else
            {
                 return -1;
            }
        }
    }
}
