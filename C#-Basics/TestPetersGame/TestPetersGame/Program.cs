using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPetersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            string lettter = Console.ReadLine();
            ulong sum = 0;
            for (ulong i = startNum; i < endNum; i++)
            {
                if ( i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }
            Console.WriteLine(sum);
            string sumStr = sum.ToString();
            if (sum % 2 == 0)
            {

                string firstChar = sumStr[0].ToString();
                Console.WriteLine(sumStr.Replace(firstChar, lettter));
            }
            else
            {
                string lastLetter = sumStr[sumStr.Length - 1].ToString();
                Console.WriteLine(sumStr.Replace(lastLetter, lettter));
            }
        }
    }
}
