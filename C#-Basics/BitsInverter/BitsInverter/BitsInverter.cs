using System;
using System.Text;
class BitsInverter
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        int step  = int.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < times; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string numAsStr = Convert.ToString(number, 2).PadLeft(8,'0');
            str = str.Append(numAsStr);
        }
        char[] readyStr = str.ToString().ToCharArray();
        for (int i = 0; i < readyStr.Length; i++)
        {
            if (i % step == 0)
            {
                if (readyStr[i] == '0')
                {
                    readyStr[i] = '1';
                }
                else
                {
                    readyStr[i] = '0';
                }
            }
        }
        string fromArrToString = new string(readyStr);
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

