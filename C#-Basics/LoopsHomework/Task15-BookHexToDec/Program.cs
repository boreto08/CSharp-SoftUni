using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string numberDec = Console.ReadLine();
            char[] numArr= new char[numberDec.Length];
            numArr = numberDec.ToCharArray();
            Array.Reverse(numArr);

            int numberBase = 16;
            int sum = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                
                 int power= (int)Math.Pow(numberBase,i);
                switch (numArr[i])
                {
                    case '0':
                      sum+=0;  ; break;
                    case '1':
                        sum+= 1*power; break;
                    case '2':
                        sum+= 2*power; break;
                    case '3':
                         sum+= 3*power; break;
                    case '4':
                         sum+= 4*power; break;
                    case '5':
                         sum+= 5*power; break;
                    case '6':
                         sum+= 6*power; break;
                    case '7':
                         sum+= 7*power; break;
                    case '8':
                         sum+= 8*power; break;
                    case '9':
                         sum+= 9*power;break;
                    case 'A':
                         sum+= 10*power; break;
                    case 'B':
                         sum+= 11*power; break;
                    case 'C':
                         sum+= 12*power; break;
                    case 'D':
                         sum+= 13*power; break;
                    case 'E':
                         sum+= 14*power; break;
                    case'F':
                         sum+= 15*power; break;
                    default: break;
                }
                
            }
            Console.WriteLine(sum);
        }
    }

