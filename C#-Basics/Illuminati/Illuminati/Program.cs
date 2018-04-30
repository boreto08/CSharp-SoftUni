using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string sentance = Console.ReadLine().ToUpper();
        char[] chArray = sentance.ToCharArray();
        int totalSum = 0;
        int vowelConter = 0;
        for (int i = 0; i < chArray.Length; i++)
        {
            if (chArray[i]=='A')
            {
                totalSum += 65;
                vowelConter++;
            }
            if (chArray[i] == 'E')
            {
                totalSum += 69;
                vowelConter++;
            }
            if (chArray[i] == 'I')
            {
                totalSum += 73;
                vowelConter++;
            }
            if (chArray[i] == 'O')
            {
                totalSum += 79;
                vowelConter++;
            }
            if (chArray[i] == 'U')
            {
                totalSum += 85;
                vowelConter++;
            }
        }
        Console.WriteLine(vowelConter);
        Console.WriteLine(totalSum);
    }
}

