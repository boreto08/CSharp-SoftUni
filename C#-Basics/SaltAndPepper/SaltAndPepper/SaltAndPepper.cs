using System;
class SaltAndPepper
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] commands = input.Split();
            string saltOrPepper = commands[0];
            int bitsToChange = int.Parse(commands[1]);
            if (saltOrPepper == "salt")
            {
                for (int i = 0; i < 64; i+=bitsToChange)
                {
                    long checkIfOne = (number >> i) & 1L;
                    if (checkIfOne == 1)
                    {
                        number = number & ~(1 << i);
                    }
                }
            }
        }
    }
}

