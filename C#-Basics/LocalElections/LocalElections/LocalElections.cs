using System;

class LocalElections
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();
        
        for (int i = 1; i < size+1; i++)
        {
            Console.WriteLine( new string('.',13));
            Console.WriteLine("...+-----+...");
            if (i != number)
            {
                Console.WriteLine("...|.....|...");
                Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2, '0'));
                Console.WriteLine("...|.....|...");
            }
            else
            {
                if (str == "x" ||  str == "X")
                {
                    Console.WriteLine( @"...|.\./.|...");
                    Console.WriteLine("{0}.|..X..|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine( @"...|./.\.|...");
                }
                else
	            {
                    Console.WriteLine( @"...|\.../|...");
                    Console.WriteLine(@"{0}.|.\./.|...",i.ToString().PadLeft(2,'0'));
                    Console.WriteLine( @"...|..V..|...");
	            }
            }
            Console.WriteLine("...+-----+...");
        }
        Console.WriteLine(new string('.', 13));
        
    }
}
