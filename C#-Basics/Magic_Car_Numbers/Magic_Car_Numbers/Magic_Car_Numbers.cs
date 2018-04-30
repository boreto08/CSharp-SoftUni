using System;
using System.Collections.Generic;


    class Magic_Car_Numbers
    {
        static void Main()
        {
            
            int magicWeight = int.Parse(Console.ReadLine());
            int numbersCount = 0;
            Dictionary<int , int> dic = new Dictionary<int,int>();
            dic.Add(0, 10);
            dic.Add(1, 20);
            dic.Add(2, 30);
            dic.Add(3, 50);
            dic.Add(4, 80);
            dic.Add(5, 110);
            dic.Add(6, 130);
            dic.Add(7, 160);
            dic.Add(8, 200);
            dic.Add(9, 240);

            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    for (int i3 = 0; i3 < 10; i3++)
                    {
                        for (int i4 = 0; i4 < 10; i4++)
                        {
                            for (int c1 = 0; c1 < 10; c1++)
                            {
                                for (int c2 = 0; c2 < 10; c2++)
                                {
                                    int sum = i + i2 + i3 + i4 + dic[c1] + dic[c2]+40;
                                    if (sum == magicWeight)
                                    {
                                        numbersCount++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(numbersCount);
        }
    }

