using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLambdaLINQ
{
    class Phonebook
    {
        static void Main()
        {
            var NameNumber = new SortedDictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (input.StartsWith("A"))
                {
                    var args = input.Split();
                    string name = args[1];
                    string number = args[2];
                    AddNameAndNumber(NameNumber, name, number);
                }
                else if (input == "ListAll")
                {
                    ListAll(NameNumber);
                }
                else
                {
                    var args = input.Split();
                    string name = args[1];
                    SearchName(NameNumber, name);   
                }
            }
        }

        public static void AddNameAndNumber(SortedDictionary<string, string> dic, string name, string number)
        {
            if (!dic.ContainsKey(name))
            {
                dic.Add(name, number);
            }
        }
        public static void SearchName(SortedDictionary<string, string> dic, string name)
        {
            
            var result = dic.FirstOrDefault(n => n.Key == name).Key;
            if (result == null)
            {
                Console.WriteLine($"Contact {name} does not exist.");
                
            }
            else
            {
                Console.WriteLine($"{result} -> {dic[result]}");
            }
            
        }
        public static void ListAll(SortedDictionary<string, string> dic)
        {
            foreach (var person in dic)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
            

    }
}
