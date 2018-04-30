using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main()
        {
            Dictionary<string, Country> CountryCityDic = FillPopulation();
            PrintReport(CountryCityDic);
        }

        private static void PrintReport(Dictionary<string, Country> countryCityDic)
        {
            foreach (var country in countryCityDic.OrderByDescending( c=> c.Value.TotalPopulation))
            {
                
                Console.WriteLine($"{country.Key} (total population: {country.Value.TotalPopulation})");
                foreach (var city in country.Value.CityPopulation.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }

        private static Dictionary<string, Country> FillPopulation()
        {
            Dictionary<string, Country> countryCityDic = new Dictionary<string, Country>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input  == "report")
                {
                    break;
                }
                var args = input.Split('|');
                string cityName = args[0];
                string country = args[1];
                int people = int.Parse(args[2]);
                
                if (!countryCityDic.ContainsKey(country))
                {
                    Country currnetCountry = new Country();
                    currnetCountry.CountryName = country;
                    currnetCountry.CityPopulation.Add(cityName, people);
                    currnetCountry.TotalPopulation += people;
                    countryCityDic.Add(country, currnetCountry);
                }
                else
                {
                    if (!countryCityDic[country].CityPopulation.ContainsKey(cityName))
                    {
                        countryCityDic[country].CityPopulation.Add(cityName, people);
                        countryCityDic[country].TotalPopulation += people;

                    }
                    else
                    {
                        countryCityDic[country].CityPopulation[cityName] += people;
                        countryCityDic[country].TotalPopulation += people;
                    }
                }
            }

            return countryCityDic;

           

        }
    }
}
