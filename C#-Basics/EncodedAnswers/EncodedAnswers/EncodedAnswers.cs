using System;
using System.Collections.Generic;
class EncodedAnswers
{
    static void Main()
    {
        uint numberOfQuestions = uint.Parse(Console.ReadLine());
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        List<char> ch = new List<char>();
        for (int i = 0; i < numberOfQuestions; i++)
        {
            uint questionAnswer = uint.Parse(Console.ReadLine());
            uint reminder = questionAnswer % 4;
            switch (reminder)
            {
                case 0: ch.Add('a');
                        A++;
                        break;
                case 1: ch.Add('b');
                        B++;
                        break;
                case 2: ch.Add('c');
                        C++;
                        break;
                case 3: ch.Add('d');
                        D++;
                        break;
            }
        }

        Console.WriteLine(string.Join(" ",ch.ToArray()));
        Console.WriteLine("Answer A: {0}",A);
        Console.WriteLine("Answer B: {0}",B);
        Console.WriteLine("Answer C: {0}",C);
        Console.WriteLine("Answer D: {0}",D);
    }
}

