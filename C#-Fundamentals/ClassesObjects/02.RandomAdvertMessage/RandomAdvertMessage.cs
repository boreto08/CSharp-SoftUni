using System;

class ProgrRandomAdvertMessageam
{
    static void Main()
    {
        string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] events = new string[] 
        { "Now I feel good.", "I have succeeded with this product.",
          "Makes miracles. I am happy of the results!",
          "I cannot believe but now I feel awesome.",
          "Try it yourself, I am very satisfied.",
          "I feel great!"
        };
        string[] phrase = new string[] 
        {
            "Excellent product.", "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        Random randCities = new Random();
        Random randAuthor = new Random();
        Random randEvents = new Random();
        Random randPhrase = new Random();

        int times = int.Parse(Console.ReadLine());

        for (int i = 0; i < times; i++)
        {
            string advert = string.Format("{0} {1} {2} - {3}"
                , phrase[randPhrase.Next(0, phrase.Length)]
                , events[randEvents.Next(0, events.Length)]
                , author[randAuthor.Next(0, author.Length)]
                , cities[randCities.Next(0, cities.Length)]);
            Console.WriteLine(advert);
        }

    }
}

