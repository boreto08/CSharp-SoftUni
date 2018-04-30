using System;

    class ImpressTheGirlfriend
    {
        static void Main()
        {
            //•	The number r – amount of rubles Spiro has to pay for the game at the Russian site.
            //•	The number d – amount of dollars Spiro has to pay for the game at the American site.
            //•	The number e – amount of euro Spiro has to pay for the game at the official site.
            //•	The number b – amount of leva Spiro has to pay for the special offer at B.
            //•	The number m – amount of leva Spiro has to pay for the game at M's site.

            uint r = uint.Parse(Console.ReadLine());
            uint d = uint.Parse(Console.ReadLine());
            uint e = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            uint m = uint.Parse(Console.ReadLine());

            decimal rInLeva = (r / 100) * 3.5m;
            decimal dInLeva = d * 1.5m;
            decimal eInLeva = e * 1.95m;
            decimal bForOne = b / 2m;
            decimal max = (decimal)Math.Max(rInLeva, Math.Max(dInLeva, Math.Max(eInLeva, Math.Max(bForOne, m))));
            Console.WriteLine("{0:f2}", Math.Ceiling(max));

        }
        
    }

