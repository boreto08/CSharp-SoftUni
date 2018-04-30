using System;
class ChangeEvenBits
{
    static void Main()
    {
        int sizeN  = int.Parse(Console.ReadLine());
        long[] numbers = new long[sizeN];
        int changedOne = 0;
        for (int i = 0; i < sizeN; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        long numToChange = long.Parse(Console.ReadLine());
        for (int j = 0; j < sizeN; j++)
        {
            long startNum = numbers[j];
            int bitLenght = Convert.ToString(startNum, 2).Length;
            //Change even bits of numToChange to 1
            for (int pos = 0; pos <= (bitLenght*2) - 2; pos+=2)
            {
                long checkIfOne = (numToChange >> pos) & 1;
                if (checkIfOne != 1)
                {
                    numToChange = numToChange | (1 << pos);
                    changedOne++;
                }
            }

        }
        Console.WriteLine(numToChange);
        Console.WriteLine(changedOne);
    }
}

