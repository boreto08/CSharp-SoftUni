using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex regex = new Regex("^(aa|aba|bcc|cc|cdc)");
        StringBuilder strBuild = new StringBuilder();
        while (input.Length > 0)
        {
            Match match = regex.Match(input);
            if (!match.Success)
            {
                Console.WriteLine("No");
                return;
            }

            switch (match.Groups[0].ToString())
            {
                case "aa":
                    strBuild.Append("0");
                    break;
                case "aba":
                    strBuild.Append("1");
                    break;
                case "bcc":
                    strBuild.Append("2");
                    break;
                case "cc":
                    strBuild.Append("3");
                    break;
                case "cdc":
                    strBuild.Append("4");
                    break;
            }
             
            input = input.Substring(match.Length, input.Length - match.Length);
        }
        BigInteger decimalNum = baseFiveToDecimal(strBuild.ToString());
        Console.WriteLine(decimalNum);

    }

    public static BigInteger baseFiveToDecimal(string baseFiveNum)
    {
        BigInteger result = 0;
        for (int i = 0; i < baseFiveNum.Length; i++)
        {
           BigInteger num = baseFiveNum[baseFiveNum.Length - 1 - i] - '0';
           num = num * BigInteger.Pow(5,i);
           result += num;
        }
        return result;
    }

}

