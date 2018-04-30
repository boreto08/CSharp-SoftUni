using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {



        int inputNumber = int.Parse(Console.ReadLine());
        int numberBase = 16;
        List<char> outputList = new List<char>();

        if (inputNumber == 0)
        {
            Console.WriteLine(0);
        }
        else
        {

            while (inputNumber > 0)
            {
                switch (inputNumber % numberBase)
                {
                    case 0:
                        outputList.Add('0'); break;
                    case 1:
                        outputList.Add('1'); break;
                    case 2:
                        outputList.Add('2'); break;
                    case 3:
                        outputList.Add('3'); break;
                    case 4:
                        outputList.Add('4'); break;
                    case 5:
                        outputList.Add('5'); break;
                    case 6:
                        outputList.Add('6'); break;
                    case 7:
                        outputList.Add('7'); break;
                    case 8:
                        outputList.Add('8'); break;
                    case 9:
                        outputList.Add('9'); break;
                    case 10:
                        outputList.Add('A'); break;
                    case 11:
                        outputList.Add('B'); break;
                    case 12:
                        outputList.Add('C'); break;
                    case 13:
                        outputList.Add('D'); break;
                    case 14:
                        outputList.Add('E'); break;
                    case 15:
                        outputList.Add('F'); break;
                    default: break;
                }

                inputNumber = inputNumber / numberBase;
            }

            outputList.Reverse();
            foreach (var digit in outputList)
            {
                Console.Write(digit);
            }
            Console.WriteLine();



        }
    }
}

