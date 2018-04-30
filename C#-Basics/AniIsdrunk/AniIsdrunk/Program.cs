using System;



    class Program
    {
        static void Main()
        {
            int numberOfCabins =  int.Parse(Console.ReadLine());
            string nextCommand = Console.ReadLine();
            int currentPosition = 0;
            while (nextCommand != "Found a free one")
            {
                int stepsCount = int.Parse(nextCommand);
                int oldPos = currentPosition;
                currentPosition = (currentPosition + stepsCount) % numberOfCabins;
                int diff =
            }
           
        }
    }

