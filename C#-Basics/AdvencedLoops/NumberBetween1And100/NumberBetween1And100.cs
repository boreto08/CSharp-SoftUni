using System;

class NumberBetween1And100
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Еnter a number in the range [1...100]:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number <= 100)
            {
                Console.WriteLine("The number is: {0}", number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

