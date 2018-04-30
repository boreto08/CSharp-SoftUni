using System;

class PerfectGirlfriend
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] str = new string[3];
        
        str = input.Split('\\');
        int perfectGirls = 0;
        string day = str[0];
        string phoneNumber = str[1];
        string braSize = str[2];
        string name = str[3];
         
         

        int sum = 0;

        while (true)
	    {
            sum = (braSizeValue(braSize) + SumNumber(phoneNumber) + DaysNumber(day)) - NameValue(name);
            if (sum< 6000)
            {
                Console.WriteLine("Keep searching, {0} is not for you.",name);
            }
            else
            {
                Console.WriteLine("{0} is perfect for you.",name);
                perfectGirls++;
            }
             sum = 0;
	         input = Console.ReadLine();
             if (input == "Enough dates!")
             {
                 break;
             }
             Array.Clear(str,0,str.Length);
             str = input.Split('\\');
             day = str[0];
             phoneNumber = str[1];
             braSize = str[2];
             name = str[3];
	    }
        Console.WriteLine(perfectGirls);
    }

    static int DaysNumber(string day )
    {
        switch (day)
	{
            case "Monday": return 1;
            case "Tuesday": return 2;
            case "Wednesday": return 3;
            case "Thursday": return 4;
            case "Friday": return 5 ;
            case "Saturday": return 6;
            case "Sunday": return 7;
            default: return -1;
	}
    }
    static int SumNumber(string number)
    {
        int sum = 0;
        char[] chArr= number.ToCharArray();
        for (int i = 0; i < number.Length; i++)
			{
			   sum+= (int)chArr[i]-'0';
			}
        return sum;
    }
    static int NameValue(string name)
    {
        int sum = 1;
        int firstLetter = (int)name[0];
        return sum = firstLetter * name.Length;
    }
    static int braSizeValue(string bra)
    {
        int sum = 0;
        int letterValue = (int)bra[bra.Length - 1];
        string firstPart = bra.Remove(bra.Length - 1);
        int size = int.Parse(firstPart);
        return sum = letterValue * size;
    }
}

