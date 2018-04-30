using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DragonArmy
{
    class DragonArmy
    {
        static void Main()
        {
            var ColorDragon = new Dictionary<string, List<Dragon>>();
            int count = int.Parse(Console.ReadLine());
            FillWithDragons(ColorDragon, count);
            PrintDragons(ColorDragon);
        }

        private static void PrintDragons(Dictionary<string, List<Dragon>> colorDragon)
        {
            foreach (var color in colorDragon)
            {
                double averageHealth = color.Value.Select(d => d.Health).Average();
                double averageArmor = color.Value.Select(d => d.Armor).Average();
                double averageDamage = color.Value.Select(d => d.Damage).Average();

                Console.WriteLine($"{color.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in color.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }

        private static void FillWithDragons(Dictionary<string, List<Dragon>> colorDragonDic, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var args = Console.ReadLine().Split();
                string color = args[0];
                string name = args[1];
                //health 250, damage 45, and armor 10
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (args[2] != "null")
                {
                    damage = int.Parse(args[2]);
                }
                if (args[3] != "null")
                {
                    health = int.Parse(args[3]);
                }
                if (args[4] != "null")
                {
                    armor = int.Parse(args[4]);
                }

                Dragon currentDragon = new Dragon();
                currentDragon.Name = name;
                currentDragon.Health = health;
                currentDragon.Damage = damage;
                currentDragon.Armor = armor;

                if (!colorDragonDic.ContainsKey(color))
                {
                    colorDragonDic.Add(color, new List<Dragon>());
                    colorDragonDic[color].Add(currentDragon);
                }
                else
                {
                    if (colorDragonDic[color].FirstOrDefault(d => d.Name.Equals(name)) == null)
                    {
                        colorDragonDic[color].Add(currentDragon);
                    }
                    else
                    {
                        colorDragonDic[color].Find(d => d.Name == name).Armor = currentDragon.Armor;
                        colorDragonDic[color].Find(d => d.Name == name).Health = currentDragon.Health;
                        colorDragonDic[color].Find(d => d.Name == name).Damage = currentDragon.Damage;
                    }
                }
            }
        }
    }
}
