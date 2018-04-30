using System;
class WinningNumbers
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToUpper().ToCharArray();
        int sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i] - '@';
        }
        int count = 0;
        for (int i1 = 0; i1 < 10; i1++)
        {
            for (int i2 = 0; i2 < 10; i2++)
            {
                for (int i3 = 0; i3 < 10; i3++)
                {
                    if (i1*i2*i3 == sum)
                    {
                        for (int i4 = 0; i4 < 10; i4++)
                        {
                            for (int i5 = 0; i5 < 10; i5++)
                            {
                                for (int i6 = 0; i6 < 10; i6++)
                                {
                                    if (i4 * i5 * i6 == sum)
                                    {
                                        Console.WriteLine("{0}{1}{2}-{3}{4}{5}",
                                            i1, i2, i3, i4, i5, i6);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
        }
        if (count == 0 )
        {
            Console.WriteLine("No");
        }
    }
}

