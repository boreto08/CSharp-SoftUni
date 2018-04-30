using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10.SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main()
        {
            var locationSingerDic = new Dictionary<string, Event>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var args = input.Split().ToList();
                Regex regex = new Regex(@"@[a-zA-Z]+ ");//the regex isnt perfekt
                regex.Match(input);
                if (args.Count < 4 || regex == null )
                {
                    continue;
                }

                Event currEvent = new Event();
                int ticketCount= int.Parse(args[args.Count - 1]);
                int ticketPrice = int.Parse(args[args.Count - 2]);
                int totalMoney = ticketCount * ticketPrice;
                args.RemoveAt(args.Count - 1);
                args.RemoveAt(args.Count - 1);
                string singerPlace = string.Join(" ", args);

                var arrSingerPlace = singerPlace.Split('@');
                string singer = arrSingerPlace[0];
                string place = arrSingerPlace[1];

                if (!locationSingerDic.ContainsKey(place))
                {
                    currEvent.Location = place;
                    currEvent.SingerMoneyDic.Add(singer, totalMoney);
                    locationSingerDic.Add(place, currEvent);
                }
                else
                {
                    if (!locationSingerDic[place].SingerMoneyDic.ContainsKey(singer))
                    {
                        locationSingerDic[place].SingerMoneyDic.Add(singer, totalMoney);
                    }
                    else
                    {
                        locationSingerDic[place].SingerMoneyDic[singer] += totalMoney;
                    }
                }

            }

            PrintEvents(locationSingerDic);
            

        }

        private static void PrintEvents(Dictionary<string, Event> locationSingerDic)
        {
            foreach (var location in locationSingerDic)
            {
                Console.WriteLine(location.Key);
                foreach (var singer in location.Value.SingerMoneyDic.OrderByDescending( v => v.Value))
                {
                    Console.WriteLine($"# {singer.Key} => {singer.Value}");
                }
            }
        }
    }
}
