using System;
using System.Linq;

class BohemchoTheBadGhost
{
    static void Main()
    {
        string input = Console.ReadLine();
        long score = 0;
        uint lightsOn = 0;
        while (input != "Stop, God damn it")
        {
            uint number = uint.Parse(input);
            int[] apartments = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Invert bit at position, regardless of value: bit ^ (1 << pos);
            for (int i = 0; i < apartments.Length; i++)
            {
                number ^= (uint)1 << apartments[i];
            }
            score += number;
            lightsOn += CalculateLightsOn(number);

            input = Console.ReadLine();
        }
        Console.WriteLine("Bohemcho left {0} lights on and his score is {1}",lightsOn,score);
    }

    private static uint CalculateLightsOn(uint number)
    {
        string toBinary = Convert.ToString(number, 2);
        uint lightsOn = 0;
        for (int i = 0; i < toBinary.Length; i++)
        {
            if (toBinary[i] == '1')
            {
                lightsOn++;
            }
        }
        return lightsOn;
    }
}

