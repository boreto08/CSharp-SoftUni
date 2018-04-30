using System;

class RandomProgram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int numberRandom = random.Next(min, max + 1);
            Console.WriteLine(numberRandom);
        }
    }
}

