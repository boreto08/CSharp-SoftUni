using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            DateTime birthDay = DateTime.Parse(input[0]);
            string name = input[1];
            char[] readyName = name.ToCharArray();
            int day= birthDay.Day;
            int month = birthDay.Month;
            int year = birthDay.Year;
            Console.WriteLine(name);
            bool isOdd = true;
            long sum = 0;
            int nameSum = 0;
           

            sum = day * month * year;

            if (month % 2 == 0 )
            {
                isOdd = false;
            }

            if (isOdd==true)
            {
                sum = sum * sum;
            }

            for (int i = 0; i < readyName.Length; i++)
            {
                char ch =readyName[i];
                if (char.IsUpper(ch))
                {
                    nameSum += Math.Abs((ch - 'a' + 1)*2);
                }
                else
                {
                    nameSum += Math.Abs(ch - 'a' + 1);
                }
            }
            sum+=nameSum;
            Console.WriteLine(sum);

            
            while (sum>13)
            {
                int digitSum = 0;
                while (sum>0)
                {
                     digitSum += (int)(sum % 10);
                sum /= 10;
                }
                sum = digitSum;
            }
            Console.WriteLine(sum);
            

            



          

        }

        
    }

