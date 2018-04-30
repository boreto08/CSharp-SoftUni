using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltPepperNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());
            long number = (long)inputNumber;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] commands = input.Split();
                string saltOrPepper = commands[0];
                int bitsToChange = int.Parse(commands[1]);
                if (saltOrPepper == "salt")
                {
                    for (int i = 0; i < 64; i += bitsToChange)
                    {
                        long checkIfOne = (number >> i) & 1L;
                        if (checkIfOne == 1)
                        {
                            number = number & ~(1L << i);
                        }
                    }
                }
                else if (saltOrPepper == "pepper")
                {
                    for (int i = 0; i < 64; i += bitsToChange)
                    {
                        long checkIfZero = (number >> i) & 1L;
                        if (checkIfZero == 0)
                        {
                            number = number | (1L << i);
                        }
                    }
                }
            }
            ulong result = (ulong)number;
            Console.WriteLine(result);
        }
    }
}
