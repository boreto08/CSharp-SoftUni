using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int startPos = 0;
        int lenght = 0;
        int maxStartPos = 0;
        int maxLenght = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length -1)
            {
                if (array[i] < array[i + 1])
                {
                    lenght++;
                    Console.Write(array[i] + " ");
                }
                else
                {
                    if (i >= 1)
                    {
                        if (array[i - 1] < array[i])
                        {
                            lenght++;
                            if (lenght > maxLenght)
                            {
                                maxLenght = lenght;
                                maxStartPos = i - (lenght -1);
                            }
                           
                            lenght = 0;
                            Console.WriteLine(array[i]);
                            continue;
                        }
                    }
                    
                    Console.WriteLine(array[i]);
                    lenght = 1;
                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        maxStartPos = i - (lenght - 1);
                    }
                }
            }
            else
            {
                if (array[i] > array[i - 1])
                {
                    lenght++;
                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        maxStartPos = i - (lenght - 1);
                        
                    }
                    Console.Write(array[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(array[i]);
                    lenght = 1;
                    if (lenght > maxLenght)
                    {
                        maxLenght = lenght;
                        maxStartPos = i - (lenght - 1);
                    }
                }
            }
         }
        //Print
        Console.Write("Longest sequance:");
        for (int i = maxStartPos; i < maxStartPos+maxLenght; i++)
        {
            Console.Write(array[i]+" ");
        }
        Console.WriteLine();
        
    }
}

