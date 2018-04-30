using System;

class Program
{
    static void Main()
    {
        //•	When the average time is lower than 720 seconds - give a Gold Star
        //•	When the average time is between 720 and 1440 seconds – give a Silver Star
        //•	When the average time is higher than 1440 seconds – give a Bronze Star

        int gamesPlayed = 0;
        int totalSeconds = 0;

        string gameTime = Console.ReadLine();
        while (gameTime != "Quit")
        {
            gamesPlayed++;
            int min = int.Parse(gameTime.Substring(0, 2));
            int seconds = int.Parse(gameTime.Substring(3, 2));
            totalSeconds += 60 * min + seconds;

            gameTime = Console.ReadLine();
        }

        double average = (double)totalSeconds / gamesPlayed;
        if (average < 720)
        {
            Console.WriteLine("Gold Star");
        }
        else if (average >= 720 && average <= 1440)
        {
            Console.WriteLine("Silver Star");
        }
        else
        {
            Console.WriteLine("Bronze Star");
        }

        Console.WriteLine("Games - {0} \\ Average seconds - {1}", gamesPlayed, Math.Ceiling(average));
       
    }
}

