using System;
class BitBuilder
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        while (true)
        {
            string input = Console.ReadLine();
            int position;
            if (input != "quit")
            {
                position = int.Parse(input);
            }
            else
            {
                break;
            }
            string command = Console.ReadLine();

            switch (command)
            {
                case "flip": 
                    number ^= 1 << position; 
                    break;
                case "remove":
                   number = RemoveBit(number, position);
                    break;
                case "insert":
                    number = InsertBit(number, position);
                    break;
                
            }
        }
        Console.WriteLine(number);
    }

    static int RemoveBit(int n, int pos)
    {
        string nASstring = Convert.ToString(n, 2).PadLeft(32, '0');
        string result = nASstring.Remove(nASstring.Length - 1 - pos, 1);
        int resultAsInt = Convert.ToInt32(result, 2);
        return resultAsInt;
    }
    static int InsertBit(int n, int pos)
    {

        string nASstring = Convert.ToString(n, 2).PadLeft(32, '0');
        string result;
        if (pos != 0 )
        {
            result = nASstring.Insert(nASstring.Length - pos, "1");
        }
        else
        {
            result = nASstring.Insert(nASstring.Length - 1, "1");
            int resultInt = Convert.ToInt32(result, 2);
            resultInt = resultInt >> 1;
            result = resultInt.ToString();
        }
        
        int resultAsInt = Convert.ToInt32(result, 2);
        return resultAsInt;
    }

}

