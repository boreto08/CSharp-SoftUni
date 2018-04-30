using System;

class Fibboncaii
{
    static void Main()
    {
        int fibNumber = int.Parse(Console.ReadLine());
        int result = 0;
        if (fibNumber == 1 ||  fibNumber == 0)
        {
            Console.WriteLine(1);
            return;
        }

        int firstNum = 1;
        int secNum = 1;
        int thirdNum = 0;

        for (int i = 0; i < fibNumber-1; i++)
        {
            thirdNum = firstNum + secNum;
            firstNum = secNum;
            secNum = thirdNum;
        }
        Console.WriteLine(thirdNum);
    }
}

