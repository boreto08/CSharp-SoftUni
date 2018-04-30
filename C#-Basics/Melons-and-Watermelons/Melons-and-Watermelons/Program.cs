using System;

class Program
{
    static void Main()
    {
        //Monday	1 Watermelon
        //Tuesday	2 Melons
        //Wednesday	1 Watermelon and 1 Melon
        //Thursday	2 Watermelons
        //Friday	2 Watermelons and 2 Melons
        //Saturday	1 Watermelon and 2 Melons
        //Sunday	Didko takes a break

        int startDayOfWeek = int.Parse(Console.ReadLine());
        int daysEating = int.Parse(Console.ReadLine());

        int melons = 0;
        int watermelons = 0;
        for (int i = startDayOfWeek; i < daysEating + startDayOfWeek; i++)
        {
            switch (i % 7)
            {
                case 1:
                    watermelons += 1;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    watermelons += 1;
                    melons += 1;
                    break;
                case 4:
                    watermelons += 2; break;
                case 5:
                    melons += 2;
                    watermelons += 2;
                    break;
                case 6:
                    watermelons += 1;
                    melons += 2;
                    break;
                default:
                    break;
            }
        }

        int diff = Math.Abs(melons - watermelons);
        if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", diff);
        }
        else if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons ", diff);
        }
        else
        {
            Console.WriteLine("Equal amount: {0}", melons);
        }


    }
}
