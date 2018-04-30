using System;
using System.Collections.Generic;
class next
{
    static void Main()
    {
        int[] array = new int[31];
        int lenght = array.Length;
        for (int i = 0; i < 5; i++)
        {
            array[lenght - 1 - i] = 1;
        }
        string number = string.Join("",array);
       
       
    }
}

