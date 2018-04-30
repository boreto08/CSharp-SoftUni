using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main()
        {
            var dic = new SortedDictionary<string, User>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var args = input.Split();
                string ip = args[0].TrimStart("IP=".ToCharArray());
                Regex regex = new Regex(@"^(user=)");
                string userName = regex.Replace(args[2], "").ToString();
                User currentUser = new User();
                if (!dic.ContainsKey(userName))
                {
                    currentUser.Name = userName;
                    if (!currentUser.IpAndCount.ContainsKey(ip))
                    {
                        currentUser.IpAndCount.Add(ip, 1);
                    }
                    dic.Add(userName, currentUser);
                    
                }
                else
                {
                    if (!dic[userName].IpAndCount.ContainsKey(ip))
                    {
                        dic[userName].IpAndCount.Add(ip, 1);
                    }
                    else
                    {
                        dic[userName].IpAndCount[ip] += 1;
                    }
                }
                
            }
            
            foreach (var user in dic)
            {
                Console.WriteLine(user.Key+ ":");
                var last = user.Value.IpAndCount.Last().Key;
               
                foreach (var ip in user.Value.IpAndCount)
                {
                    if (ip.Key == last)
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value},");
                    }
                    
                }
            }


        }
    }
}
