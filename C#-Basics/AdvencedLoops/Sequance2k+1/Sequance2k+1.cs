using System;

class Sequance2k_1
{
    static void Main()
    {
        int border = int.Parse(Console.ReadLine());
        int number = 1;
        Console.WriteLine(number);
        while (number <= border)
        {
            number = (number * 2) + 1;
            if (number > border)
            {
                break;
            }
            Console.WriteLine(number);
        }
    }
}

