using System;
class WeirdCombinations
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        int numCombination = int.Parse(Console.ReadLine());
        int count = -1;

        for (int ch1 = 0; ch1 < pattern.Length; ch1++)
        {
            for (int ch2 = 0; ch2 < pattern.Length; ch2++)
            {
                for (int ch3 = 0; ch3 < pattern.Length; ch3++)
                {
                    for (int ch4 = 0; ch4 < pattern.Length; ch4++)
                    {
                        for (int ch5 = 0; ch5 < pattern.Length; ch5++)
                        {
                            count++;
                            if (count == numCombination)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}", pattern[ch1], pattern[ch2], pattern[ch3], pattern[ch4], pattern[ch5]);
                            }
                        }
                    }
                }
            }
        }
        if (numCombination > count)
        {
            Console.WriteLine("No");
        }

    }
}

