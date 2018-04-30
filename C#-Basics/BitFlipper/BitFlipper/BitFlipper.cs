using System;

class BitFlipper
{
    static void Main()
    {
        long number = 8773276988229695713;
        string numAsString = Convert.ToString(number,2).PadLeft(64,'0');
        char[] chArr = numAsString.ToCharArray();
        for (int i = 2; i < numAsString.Length; i++)
        {
            if (chArr[i] == chArr[i-1] && chArr[i] == chArr[i-2])
            {
                if (chArr[i] == '0')
                {
                    chArr[i] = '1';
                    chArr[i-1] = '1';
                    chArr[i-2] = '1';
                }
                else 
                {
                    chArr[i] = '0';
                    chArr[i - 1] = '0';
                    chArr[i - 2] = '0';
                }
                i += 2;
            }
        }
        Console.WriteLine(Convert.ToInt64(new string(chArr),2));


        


        
    }
}

