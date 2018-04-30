using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('\\');
            char[] leftArr=input[0].ToCharArray();
            char[] rightArr=input[1].ToCharArray();
            string command=input[2];
            List<char> result=new List<char>();
        //    Console.WriteLine(leftArr); ABCD\CAFG\left exclude
        //    Console.WriteLine(rightArr);
        //    Console.WriteLine(command);
            for (int i = 0; i < leftArr.Length; i++)
            {
                int count = 0;
                bool currentIsHere = false;
                char currentLeft = leftArr[i];
                for (int j = 0; j <rightArr.Length; j++)
                {
                    char currentRight = rightArr[j];
                    if (command== "join")
                    {
                        if (currentLeft==currentRight)
                        {
                            result.Add(currentLeft);
                        }
                    }
                  
                    
                    else if (command == "right exclude")
                    {
                        if (currentLeft == currentRight)
                        {
                            currentIsHere = true;
                            if (currentIsHere)
                            {
                                break;
                            }
                        }
                        else if (currentLeft != currentRight  )
                        {
                            count++;
                            if (count == rightArr.Length)
                            {
                                result.Add(currentLeft);
                            }
                        }
                      
                    }
                   
                }
            }
            if (command=="left exclude")
            {
                for (int k = 0; k < rightArr.Length; k++)
                {
                    if (!leftArr.Contains(rightArr[k]))
                    {
                        result.Add(rightArr[k]);
                    }
                }           
            }
            foreach (var ch in result)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }

