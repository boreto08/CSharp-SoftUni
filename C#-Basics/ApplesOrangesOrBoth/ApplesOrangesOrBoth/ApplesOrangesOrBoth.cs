using System;

class ApplesOrangesOrBoth
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;
        while (number > 0)
        {
            int currentNum = number % 10;
            number /= 10;
            if (currentNum % 2 == 0)
            {
                evenSum += currentNum;
            }
            else if (currentNum % 2 != 0)
            {
                oddSum += currentNum;
            }
        }
        if (oddSum > evenSum)
        {
            Console.WriteLine("{0} oranges",oddSum);
        }
        else if (evenSum > oddSum)
        {
             Console.WriteLine("{0} apples",evenSum);
        }
        else
        {
            Console.WriteLine("{0} both",evenSum);
        }
    }
}

