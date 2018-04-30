using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(braSizeValue(str));

        }
        static int braSizeValue(string bra)
        {
            int sum = 0;
            int letterValue = (int)bra[bra.Length - 1];
            string firstPart = bra.Remove(bra.Length - 1);
            int size = int.Parse(firstPart);
            return sum = letterValue * size;
        }
        
    }
}
