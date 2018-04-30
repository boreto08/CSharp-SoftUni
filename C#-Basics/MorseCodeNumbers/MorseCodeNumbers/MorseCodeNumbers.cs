using System;

class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int nSum = 0;
        bool noMatchesFound = true;
        while (n > 0 )
        {
            int lastDigit = n % 10;
            n /= 10;
            nSum += lastDigit;
        }
        for (int i1 = 0; i1 < 6; i1++)
        {
            for (int i2 = 0; i2 < 6; i2++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    for (int i4 = 0; i4 < 6; i4++)
                    {
                        for (int i5 = 0; i5 < 6; i5++)
                        {
                            for (int i6 = 0; i6 < 6; i6++)
                            {
                                int currentProduct = i1 * i2 * i3 * i4 * i5 * i6;
                                if (currentProduct == nSum)
                                {
                                    noMatchesFound = false;
                                    PrintPattern(i1);
                                    PrintPattern(i2);
                                    PrintPattern(i3);
                                    PrintPattern(i4);
                                    PrintPattern(i5);
                                    PrintPattern(i6);
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
        if (noMatchesFound)
        {
            Console.WriteLine("No");
        }
    }
    static void PrintPattern(int number)
    {
        switch (number)
        {
            case 0: 
                Console.Write("-----"); 
                break;
            case 1:
                Console.Write(".----"); 
                break;
            case 2:
                Console.Write("..---");
                break;
            case 3:
                Console.Write("...--");
                break;
            case 4:
                Console.Write("....-");
                break;
            case 5:
                Console.Write(".....");
                break;
        }
    }

}

