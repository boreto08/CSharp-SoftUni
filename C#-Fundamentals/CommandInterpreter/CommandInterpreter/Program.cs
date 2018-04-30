using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main()
        {
            //See the video about the task
            List<string> list = Console.ReadLine().Split(new char[] { ' ','\t' },StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var args = input.Split();
                var command = args[0];

                int startIndex = 0;
                int count = 0;

                if (command == "reverse")
                {
                    startIndex = int.Parse(args[2]);
                    count = int.Parse(args[4]);
                    if (startIndex >= 0 && startIndex < list.Count  && startIndex + count <= list.Count && count >= 0)
                    {
                        ReverseElements(list, startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else if (command == "sort")
                {
                    startIndex = int.Parse(args[2]);
                    count = int.Parse(args[4]);
                    if (startIndex >= 0 && startIndex < list.Count && startIndex + count <= list.Count && count >= 0)
                    {
                        SortElements(list, startIndex, count);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }
                }
                else if (command == "rollLeft")
                {
                    count = int.Parse(args[1]);
                    RollLeft(list, count);
                }
                else if (command == "rollRight")
                {
                    count = int.Parse(args[1]);
                    RollRight(list, count);
                }
            }
            Console.WriteLine("[" + string.Join(", ",list) + "]");

        }

        private static void RollRight(List<string> list, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            int lenght = count % list.Count;
            for (int i = 0; i < lenght; i++)
            {
                string lastElement = list[list.Count - 1];
                list.RemoveAt(list.Count -1);
                list.Insert(0, lastElement);
            }
            

            
        }

        private static void RollLeft(List<string> list, int count)
        {

            if (count < 0 )
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            int lenght = count % list.Count;
            for (int i = 0; i < lenght; i++)
            {

                string firstElemet = list[0];

                list.RemoveAt(0);
                list.Add(firstElemet);
                
            }
            
        }

        private static void SortElements(List<string> list, int startIndex, int count)
        {

            list.Sort(startIndex, count, StringComparer.InvariantCulture);
        }

        private static void ReverseElements(List<string> list, int startIndex, int count)
        {
            list.Reverse(startIndex, count);
        }
    }
}
