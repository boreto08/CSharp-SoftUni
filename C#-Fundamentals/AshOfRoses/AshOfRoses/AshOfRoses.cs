using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class AshOfRoses
{
    static void Main()
    {
        var mapNameRegion = new Dictionary<string, Region>();
        Regex regex = new Regex(@"\b^Grow \<([A-Z][a-z]*)\> \<([A-Za-z\d]+)\> (\d+)$");
        
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Icarus, Ignite!")
            {
                break;
            }
            if (!regex.IsMatch(input))
            {
                continue;
            }
            var match = regex.Match(input);

            string region = match.Groups[1].ToString();
            string color = match.Groups[2].ToString();
            decimal roses = decimal.Parse(match.Groups[3].ToString());

            if (!mapNameRegion.ContainsKey(region))
            {
                Region currRegion = new Region();
                currRegion.Name = region;
                currRegion.mapColorAmount.Add(color, roses);
                mapNameRegion.Add(region, currRegion);
            }
            else
            {
                if (!mapNameRegion[region].mapColorAmount.ContainsKey(color))
                {
                    mapNameRegion[region].mapColorAmount.Add(color, roses);
                }
                else
                {
                    mapNameRegion[region].mapColorAmount[color] += roses;                   
                }
            }
        }

        mapNameRegion
            .OrderByDescending(x => x.Value.calcAllRosesInRegion())
            .ThenBy(x => x.Value.Name)
            .ToList()
            .ForEach(x =>
        {
            Console.WriteLine(x.Value.Name);
            foreach (var rose in x.Value.mapColorAmount.OrderBy(y => y.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"*--{rose.Key} | {rose.Value}");
            }
        });

    }
}

class Region
{
    public string Name { get; set; }
    public Dictionary<string,decimal> mapColorAmount { get; set; }

    public Region()
    {
        this.mapColorAmount = new Dictionary<string, decimal>();
    }

    public decimal calcAllRosesInRegion()
    {
        decimal result = 0;
        foreach (var roses in mapColorAmount.Values)
        {
            result += roses;
        }

        return result;
    }
}

