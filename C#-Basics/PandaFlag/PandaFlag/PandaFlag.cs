using System;

class PandaFlag
{
    static void Main()
    {
        int n =int.Parse(Console.ReadLine());
        char startCH = (char)64;
       
        for (int i = 0; i <n/2 ; i++)
        {

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', i), startCH = GetNextLetter(startCH), new string('#', n - 2 - (2 * i)), startCH = GetNextLetter(startCH));
           
        }
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), startCH = GetNextLetter(startCH));
        for (int i =0 ; i < n/2; i++)
        {

            Console.WriteLine("{0}{1}{2}{3}{0}", new string('~', n / 2 - 1 - i), startCH = GetNextLetter(startCH), new string('#', n / n + (2 * i)), startCH = GetNextLetter(startCH));
            
             
        }
    }
    static char GetNextLetter(char letter)
    {
        letter++;
        if (letter > 'Z')
        {
            letter = 'A';
        }
        return letter;
    }
}

