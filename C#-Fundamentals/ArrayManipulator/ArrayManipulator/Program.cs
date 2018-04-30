using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            var listNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "print")
                {
                    break;
                }
                var args = input.Split();
                var command = args[0];
                switch (command)
                {
                    case "add":
                        AddElement(args,listNums);
                        break;
                    case "addMany":
                        AddMany(args, listNums);
                        break;
                    case "contains":
                       int index = ContainsElement(args, listNums);
                        Console.WriteLine(index);
                        break;
                    case "remove":
                        RemoveElement(args, listNums);
                        break;
                    case "shift":
                        RollLeft(args, listNums);
                        break;
                    case "sumPairs":
                        listNums = SumPairs(listNums);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("[{0}]",string.Join(", ",listNums));

        }

        private static List<int> SumPairs(List<int> listNums)
        {
            var sumedList = new List<int>();
            if (listNums.Count % 2 == 0)
            {
                for (int i = 0; i < listNums.Count - 1; i+=2)
                {
                    sumedList.Add(listNums[i] + listNums[i + 1]);
                }
            }
            else
            {
                for (int i = 0; i < listNums.Count - 2; i+=2)
                {
                    sumedList.Add(listNums[i] + listNums[i + 1]);
                }
                sumedList.Add(listNums[listNums.Count - 1]);
            }
            return sumedList;
        }

        private static void RollLeft(string[] args, List<int> listNums)
        {
            int times = int.Parse(args[1]) % listNums.Count;
            for (int i = 0; i < times; i++)
            {
                int firstElement = listNums[0];
                listNums.RemoveAt(0);
                listNums.Add(firstElement);
            }
        }

        private static void RemoveElement(string[] args, List<int> listNums)
        {
            int index = int.Parse(args[1]);
            listNums.RemoveAt(index);
        }

        private static int ContainsElement(string[] args, List<int> listNums)
        {
            int element = int.Parse(args[1]);
            bool isThere = listNums.Contains(element);
            if (isThere)
            {

                return listNums.IndexOf(element);
                
            }
            else
            {
                return -1;
            }

        }

        private static void AddMany(string[] args, List<int> listNums)
        {
            int index = int.Parse(args[1]);
            var subList = new List<int>();
            for (int i = 2; i < args.Length; i++)
            {
                subList.Add(int.Parse(args[i]));
            }
            subList.Reverse();
            foreach (var num in subList)
            {
                listNums.Insert(index, num);
            }
            
        }

        private static void AddElement(string[] args,List<int> listNum)
        {
            int index = int.Parse(args[1]);
            int element = int.Parse(args[2]);

            listNum.Insert(index, element);
        }
    }
}
