using System;

class EvenNumber
{
    static void Main()
    {
        while (true)
        {
            int number = 0;
            Console.Write("Enter even number: ");
            try
            {
                 number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
                continue;
            }
            
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number entered: {0}", number);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

