using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinerTask
{
    class MinerTask
    {
        static void Main()
        {
            var ResorceQuantity = new Dictionary<string, string>();
            FillDictionary(ResorceQuantity);
            PrintResources(ResorceQuantity);
        }

        public static void FillDictionary(Dictionary<string, string> dic)
        {
            

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                string quantity = Console.ReadLine();
                
                if (!dic.ContainsKey(input))
                {
                    dic.Add(input, quantity);
                }
                
            }
        }
        public static void PrintResources(Dictionary<string, string> dic)
        {
            foreach (var resource in dic)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
