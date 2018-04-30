using System;

    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 < 10; i1++)
            {
                for (int i2 = 1; i2 < 10; i2++)
                {
                    for (int i3 = 1; i3 < 10; i3++)
                    {
                        for (int i4 = 1; i4 < 10; i4++)
                        {
                            int remainderI1 = n % i1;
                            int remainderI2 = n % i2;
                            int remainderI3 = n % i3;
                            int remainderI4 = n % i4;
                            if (remainderI1 == 0 && remainderI2 == 0 && remainderI3 == 0 && remainderI4 ==0)
                            {
                                Console.Write("{0}{1}{2}{3} ",i1,i2,i3,i4);
                            }
                        }
                    }
                }
            }
        }
    }

