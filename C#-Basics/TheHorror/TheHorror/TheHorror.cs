using System;

class TheHorror
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
	        {
                int number = int.Parse(input[i].ToString());
                sum += number;
                count++;
	        }
            
        }
        Console.WriteLine("{0} {1}",count,sum);
        
    }
}

