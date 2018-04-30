using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Regex regex = new Regex("^<\\s*([a-zA-Z]+)\\s*");
        List<string> result = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "<stop/>")
            {
                break;
            }
            Match matchCommand = regex.Match(input);
            string command = matchCommand.Groups[1].ToString();

            Regex regexContent = new Regex("content\\s*=\\s*\"\\s*(.+)\\s*\"");
            string content = regexContent.Match(input).Groups[1].ToString();
            if (content.Length == 0)
            {
                continue;
            }
            switch (command)
            {
                case "reverse":
                    result.Add(new string(content.Reverse().ToArray()));
                    break;
                case "inverse":
                    StringBuilder sb = new StringBuilder();
                    foreach (var ch in content.ToCharArray())
                    {
                        if (char.IsUpper(ch))
                        {
                            sb.Append(char.ToLower(ch));
                        }
                        else
                        {
                            sb.Append(char.ToUpper(ch));
                        }
                    }
                    result.Add(sb.ToString());
                    break;
                case "repeat":
                    Regex regexValue = new Regex("value\\s*=\\s*\"\\s*([0-9]+)\\s*\"");
                    int times = int.Parse(regexValue.Match(input).Groups[1].ToString());
                    for (int i = 0; i < times; i++)
                    {
                        result.Add(content.ToString());
                    }
                    break;
            }
        }
        int count = 1;
        foreach (var text in result)
        {
            Console.WriteLine($"{count}. {text}");
            count++;
        }

    }


}
