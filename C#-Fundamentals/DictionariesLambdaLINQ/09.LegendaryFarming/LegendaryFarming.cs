using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main()
        {
            Dictionary<string, int> itemQuantity = new Dictionary<string, int>();
            Dictionary<string, int> specialItem = new Dictionary<string, int>();
            //•	Shadowmourne – requires 250 Shards;
            //•	Valanyr – requires 250 Fragments;
            //•	Dragonwrath – requires 250 Motes;
            specialItem.Add("shards", 0);
            specialItem.Add("fragments", 0);
            specialItem.Add("motes", 0);
            bool isEnought = false;
            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length - 1; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1];
                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        specialItem[item] += quantity;

                        if (specialItem["shards"] >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            specialItem["shards"] -= 250;
                            isEnought = true;
                            break;
                        }
                        else if (specialItem["fragments"] >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            specialItem["fragments"] -= 250;
                            isEnought = true;
                            break;
                        }
                        else if (specialItem["motes"] >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            specialItem["motes"] -= 250;
                            isEnought = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!itemQuantity.ContainsKey(item))
                        {
                            itemQuantity.Add(item, quantity);
                        }
                        else
                        {
                            itemQuantity[item] += quantity;
                        }
                    }
                }
                if (isEnought)
                {
                    break;
                }


            }

            foreach (var item in specialItem.OrderByDescending(q => q.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in itemQuantity.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
