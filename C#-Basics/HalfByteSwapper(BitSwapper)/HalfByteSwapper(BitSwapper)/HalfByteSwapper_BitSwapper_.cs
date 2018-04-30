using System;
using System.Collections.Generic;
using System.Text;

class HalfByteSwapper_BitSwapper_
{
    static void Main()
    {
        int[] arrNums = new int[4];
        for (int i = 0; i < arrNums.Length; i++)
        {
            arrNums[i] = int.Parse(Console.ReadLine());
        }
        List<int> sbOther = new List<int>();
        List<int> sb  = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            string[] numberAndGroup =Console.ReadLine().Split(); 
            string[] commands = input.Split();
            int pickedNumber = int.Parse(commands[0]);
            int group = int.Parse(commands[1]);
            int pos = 0;
            switch (group)
            {
                case 1: pos = 4; break;
                case 2: pos = 8; break;
                case 3: pos = 12; break;
                case 4: pos = 16; break;
                case 5: pos = 20; break;
                case 6: pos = 24; break;
                case 7: pos = 28; break;
            }
            for (int i = 0; i < 4; i++)
            {
                int bitValue = (arrNums[pickedNumber] >> pos + i) & 1;
                sb.Add(bitValue);

            }
            int pickedNumberOther = int.Parse(numberAndGroup[0]);
            int groupOther = int.Parse(numberAndGroup[1]);
            int posOther = 0;
            switch (groupOther)
            {
                case 1: posOther = 4; break;
                case 2: posOther = 8; break;
                case 3: posOther = 12; break;
                case 4: posOther = 16; break;
                case 5: posOther = 20; break;
                case 6: posOther = 24; break;
                case 7: posOther = 28; break;
            }
            for (int i = 0; i < 4; i++)
            {
                int bitValue = (arrNums[pickedNumberOther] >> posOther + i) & 1;
                sbOther.Add(bitValue);
            }
            //Cleaning bits
            arrNums[pickedNumber] = arrNums[pickedNumber] & ~(15 << pos);
            arrNums[pickedNumberOther] = arrNums[pickedNumberOther] & ~(15 << posOther);
            //Set new bits
            for (int i = 0; i < 4; i++)
            {
                int bitValue =  sbOther[i];
                arrNums[pickedNumber] = arrNums[pickedNumber] | (bitValue << pos + i);

            }
            for (int i = 0; i < 4; i++)
            {
                int bitValue = sb[i];
                arrNums[pickedNumberOther] = arrNums[pickedNumberOther] | (bitValue << posOther + i);

            }
            sb.Clear();
            sbOther.Clear();   
        }
        //Print
        foreach (var num in arrNums)
        {
            Console.WriteLine(num);
        }

    }
}

