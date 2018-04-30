using System;

class Program
{
    static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] suits = new string[4] { " of Clubss", " of Diamonds", " of Hearts", " of Spades" };

        for (int i = 0; i < 52; i++)
        {
            Console.Write("{0}", cards[i % 13]);
            Console.WriteLine(suits[i / 13]);
        }

        
    }
}

