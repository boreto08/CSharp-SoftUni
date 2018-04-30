using System;
using System.Text;

class BitKiller
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < times; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string numAsStr = Convert.ToString(number, 2).PadLeft(8, '0');
            str = str.Append(numAsStr);
        }
        int removed = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (i % step != 0)
            {
                str = str.Remove(i, 1);
                removed++;
            }
        }
        int strLenght = str.Length;
        int zeros = 0;
        while (strLenght % 8 != 0)
        {
            strLenght++;
            zeros++;
        }
        str = str.Append(new string('0', zeros));

        string fromArrToString = new string(str.ToString().ToCharArray());
        StringBuilder sb = new StringBuilder();
        int bitCount = 0;
        for (int i = 0; i < fromArrToString.Length; i++)
        {

            sb = sb.Append(fromArrToString[i]);
            bitCount++;
            if (bitCount == 8)
            {
                bitCount = 0;
                int num = Convert.ToInt32(sb.ToString(), 2);
                Console.WriteLine(num);
                sb = sb.Clear();
            }
        }
    }
}

