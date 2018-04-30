using System;

    class Program
    {
        static void Main()
        {
            int escapeAttempts = int.Parse(Console.ReadLine());
            int thievesSlapped = 0;
            ulong thievesEscaped = 0;
            ulong beers = 0L;

            for (int i = 0; i < escapeAttempts; i++)
            {
                int thievesAttemptEscape = int.Parse(Console.ReadLine());
                int drikedBeers = int.Parse(Console.ReadLine());
                if (thievesAttemptEscape >= 5)
                {
                    thievesEscaped += (ulong)thievesAttemptEscape - 5;
                    thievesSlapped += 5;
                }
                else
                {
                    thievesSlapped += thievesAttemptEscape;
                }
                beers += (ulong)drikedBeers;
            }
          

            Console.WriteLine("{0} thieves slapped.",thievesSlapped);
            Console.WriteLine("{0} thieves escaped.", thievesEscaped);
            Console.WriteLine("{0} packs, {1} bottles.",beers/6,beers % 6);
        }
    }

