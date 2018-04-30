using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
                                                       Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            string mask= GenerateBinaryNumber(k);
            int maskToInt = Convert.ToInt32(mask, 2);
                                                            Console.WriteLine(Convert.ToString(maskToInt, 2).PadLeft(32, '0'));
            int lo = num & (maskToInt << p); // get bits 3-5
                                                                Console.WriteLine(Convert.ToString(lo, 2).PadLeft(32, '0'));
            int hi = num & (maskToInt << q); // get bits 24-26
                                                                     Console.WriteLine(Convert.ToString(hi, 2).PadLeft(32, '0'));
            Console.WriteLine("clearr");
            num &= ~lo;// clear bits 3-5 and 24-26
                                                                        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            num &= ~hi;
                                                                                        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            
            num |= lo << Math.Abs(q-p); // put bits 3-5 in 24-26
                                                                                            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            num |= hi >> Math.Abs(q - p); // put bits 24-26 in 3-5
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(num);
        }

        static string GenerateBinaryNumber(int NumberK)
        {
            int[] array = new int[31];
            int lenght = array.Length;
            for (int i = 0; i < NumberK; i++)
            {
                array[lenght - 1 - i] = 1;
            }
            string number = string.Join("", array);
            return number;

        }
    }

