using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            var NamePersonDic = new Dictionary<string, Person>();
            var singersArgs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var songsArgs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "dawn")
                {
                    break;
                }

                var inputArgs = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                var singerName = inputArgs[0].Trim();
                var songName = inputArgs[1].Trim();
                var award = inputArgs[2].Trim();

                if (!singersArgs.Contains(singerName) || !songsArgs.Contains(songName))
                {
                    continue;
                }

                Person currentPerson = new Person();
                if (!NamePersonDic.ContainsKey(singerName))
                {
                    currentPerson.Name = singerName;
                    currentPerson.Awards.Add(award);

                    NamePersonDic.Add(singerName, currentPerson);

                }
                else
                {
                    NamePersonDic[singerName].Awards.Add(award);
                }

            }

            if (NamePersonDic.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                PrintSingers(NamePersonDic);
            }
           

        }

        private static void PrintSingers(Dictionary<string, Person> namePersonDic)
        {
            foreach (var person in namePersonDic.OrderByDescending(p => p.Value.Awards.Count).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{person.Key}: {person.Value.Awards.Count} awards");
                foreach (var award in person.Value.Awards.OrderBy( a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public HashSet<string> Awards { get; set; }

        public Person()
        {
            this.Awards = new HashSet<string>();
        }
    }
}
