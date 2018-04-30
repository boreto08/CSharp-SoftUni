using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Country
    {
        public string CountryName { get; set; }
        public Dictionary<string, int> CityPopulation { get; set; }
        public int TotalPopulation { get; set; }

        public Country()
        {
            this.CityPopulation = new Dictionary<string, int>();
        }
    }
}
