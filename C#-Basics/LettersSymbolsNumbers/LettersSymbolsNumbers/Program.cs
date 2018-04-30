using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int numbers = 0;
        int symbols = 0;
        int letters = 0;
        int symbolFixedValue = 200;
        for (int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();
            line = line.ToLower();
            
            foreach (var ch in line)
            {
                if (char.IsDigit(ch))
                {
                    numbers += (ch - '0') * 20;
                }
                else if (char.IsLetter(ch))
                {
                    letters += (ch - 'a' + 1) * 10;
                }
                else if (char.IsPunctuation(ch))
                {
                    symbols += symbolFixedValue;
                }
            }

        }
                
        Console.WriteLine(letters);
        Console.WriteLine(numbers);
        Console.WriteLine(symbols);

        
    }
}

