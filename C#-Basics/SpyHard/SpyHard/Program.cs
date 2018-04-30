using System;


class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        string message = Console.ReadLine();
        message = message.ToLower();
        int sum = 0;
        string result="";
        
        foreach (var ch in message)
        {
            if (char.IsLetter(ch))
            {
                sum += ch - 'a' + 1;
            }
            else if(char.IsPunctuation(ch) || char.IsSymbol(ch))
            {
                sum += (int)ch;
            }
            else if (char.IsDigit(ch))
            {
                sum += ch ;
            }
        }
        if (key==2 || key==10)
	    {
		     result = Convert.ToString(sum,key);
	    }
        else 
	    {
           
            int reminder;
            while (sum > 0)
            {

                reminder = sum % key;
                sum =sum/ key;
                result = reminder.ToString()+ result;
            }

	    }
        
        Console.WriteLine("{0}{1}{2}",key,message.Length,result);

    }
   

    
}

