using System;

    class Name
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string Name)
        {
            Console.WriteLine("Hello {0}",Name);
        }
    }
