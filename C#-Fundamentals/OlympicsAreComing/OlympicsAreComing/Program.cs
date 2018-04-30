using System;
using System.Collections.Generic;
using System.Linq;

class OlympicsAreComing
{
    static void Main()
    {
        Dictionary<string, Country> mapNameCountry = new Dictionary<string, Country>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "report")
            {
                break;
            }
            string[] nameCountry = input.Split('|');
            string country = nameCountry[1].Trim();
            string[] nameFull = nameCountry[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string name = "";

            foreach (var n in nameFull)
            {
                name += n.Trim() + " ";
            }
            name = name.TrimEnd();
            if (!mapNameCountry.ContainsKey(country))
            {
                Country currCountry = new Country(country);
                currCountry.Participants.Add(name);
                currCountry.Wins++;
                mapNameCountry.Add(country, currCountry);
            }
            else
            {
                mapNameCountry[country].Participants.Add(name);
                mapNameCountry[country].Wins++;
            }
        }

        var sortedMap = mapNameCountry.OrderByDescending(c => c.Value.Wins);
        foreach (var country in sortedMap)
        {
            Console.WriteLine($"{country.Key} ({country.Value.Participants.Count} participants): {country.Value.Wins} wins");
        }

    }
}

public class Country
{
    private string name;
    private int wins;
    private HashSet<string> participants;

    public Country(string Name)
    {
        this.name = Name;
        this.participants = new HashSet<string>();
    }
    public string Name { get; private set; }
    public int Wins
    {
        get
        {
            return this.wins;
        }
        set
        {
            this.wins = value;
        }
    }

    public HashSet<String> Participants
    {
        get
        {
            return this.participants;
        }
        set
        {
            this.participants = value;
        }
    }

}
