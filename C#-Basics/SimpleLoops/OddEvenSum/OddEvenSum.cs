using System;
class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int odd = 0;
        int even = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                even += number;
            }
            else
            {
                odd += number;
            }
        }
        if (odd == even)
        {
            Console.WriteLine("Yes sum = {0}", odd);
        }
        else
        {
            Console.WriteLine("No diff = {0}", Math.Abs(odd - even));
        }
    }
}

