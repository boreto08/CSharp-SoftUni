using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var mapNameCity = new SortedDictionary<string, SortedDictionary<string, List<string>>>();
        int numOfLines = int.Parse(Console.ReadLine());
        Regex regex = new Regex("^#([a-zA-Z]+):\\s*@([a-zA-Z]+)\\s*([0-9]+:[0-9]+)$");
        for (int i = 0; i < numOfLines; i++)
        {
            string input = Console.ReadLine();
            var match = regex.Match(input);
            if (!match.Success)
            {
                continue;
            }
            string name = match.Groups[1].ToString();
            string city = match.Groups[2].ToString();
            string time = match.Groups[3].ToString();
            string[] timeTokens = time.Split(':');
            int hours = int.Parse(timeTokens[0]);
            int mins = int.Parse(timeTokens[1]);
            if (hours > 23 || mins > 59)
            {
                continue;
            }

            if (!mapNameCity.ContainsKey(city))
            {
                mapNameCity.Add(city, new SortedDictionary<string, List<string>>());
                mapNameCity[city].Add(name, new List<string>());
                mapNameCity[city][name].Add(time);
            }
            else
            {
                if (!mapNameCity[city].ContainsKey(name))
                {
                    mapNameCity[city].Add(name, new List<string>());
                    mapNameCity[city][name].Add(time);
                }
                else
                {
                    mapNameCity[city][name].Add(time);
                }
            }
        }

        string[] citiesToPrint = Console.ReadLine().Split(',');
        Array.Sort(citiesToPrint);
        foreach (var city in citiesToPrint)
        {
            if (!mapNameCity.ContainsKey(city))
            {
                continue;
            }
            Console.WriteLine($"{city}:");
            int count = 1;
            foreach (var pair in mapNameCity[city])
            {
                Console.Write($"{count}. {pair.Key} -> ");
                count++;
                pair.Value.Sort();
                Console.WriteLine(string.Join(", ", pair.Value));
            }

        }
    }
}



