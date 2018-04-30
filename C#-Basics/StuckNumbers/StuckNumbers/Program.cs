using System;
using System.Collections.Generic;
using System.Linq;


class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> numbers = Console.ReadLine().Split().ToList();
        List<string> numbersTemp = numbers;
        int count = 0;
        if (n < 4)
        {
            Console.WriteLine("No");
            return;
        }
        foreach (string a in numbers)
        {
            numbersTemp = numbers.ToList();
            numbersTemp.Remove(a);
            foreach (string b in numbersTemp.ToList())
            {
                numbersTemp.Remove(b);
                foreach (string c in numbersTemp.ToList())
                {
                    numbersTemp.Remove(c);
                    foreach (string d in numbersTemp)
                    {
                        if (a + b == c + d)
                        {
                            Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                            count++;
                        }
                    }
                    numbersTemp.Add(c);
                }
                numbersTemp.Add(b);
            }
            numbersTemp.Add(a);
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}