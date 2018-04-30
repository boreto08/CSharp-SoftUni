using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.FixEmails
{
    class FixEmails
    {
        static void Main()
        {
            var nameEmail = new Dictionary<string, string>();
            FillDic(nameEmail);
            RemoveForbiddenMails(nameEmail);
            PrintNameEmails(nameEmail);
        }

       
        private static void FillDic(Dictionary<string, string> nameEmail)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break; 
                }
                string email = Console.ReadLine();

                if (!nameEmail.ContainsKey(input))
                {
                    nameEmail.Add(input, email);
                }
            }
        }
        private static void RemoveForbiddenMails(Dictionary<string, string> nameEmail)
        {
            string[] forbiddenMails = { "us", "uk" };
            foreach (var domain in forbiddenMails)
            {
                if (nameEmail.Any(m => m.Value.EndsWith(domain,false,CultureInfo.InvariantCulture)))
                {
                    foreach (var item in nameEmail.Where(m => m.Value.EndsWith(domain, false, CultureInfo.InvariantCulture)).ToList())
                    {
                        nameEmail.Remove(item.Key);
                    }
                }
            }
            
        }
        private static void PrintNameEmails(Dictionary<string, string> nameEmail)
        {
            foreach (var person in nameEmail)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
