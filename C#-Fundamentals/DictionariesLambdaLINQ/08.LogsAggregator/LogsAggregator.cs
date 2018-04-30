using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            var nameUserDict = new Dictionary<string, User>();
            FillUsers(nameUserDict,count);
            PrintUsers(nameUserDict);
        }

        private static void PrintUsers(Dictionary<string, User> nameUserDict)
        {
            foreach (var user in nameUserDict.Values.OrderBy( u => u.Name))
            {
                Console.Write($"{user.Name}: {user.totalDuration} [");
                Console.Write(string.Join(", ",user.IPs.OrderBy( i => i)));
                Console.WriteLine("]");
            }
        }

        private static void FillUsers(Dictionary<string, User> nameUserDict, int usersCount)
        {
            for (int i = 0; i < usersCount; i++)
            {
                var args = Console.ReadLine().Split();
                string ip = args[0];
                string userName = args[1];
                int currentDuration = int.Parse(args[2]);

                if (!nameUserDict.ContainsKey(userName))
                {
                    User user = new User();
                    user.Name = userName;
                    user.totalDuration += currentDuration;
                    user.IPs.Add(ip);

                    nameUserDict.Add(userName, user);
                }
                else
                {
                    nameUserDict[userName].totalDuration += currentDuration;
                    nameUserDict[userName].IPs.Add(ip);
                }
            }
        }
    }
}
