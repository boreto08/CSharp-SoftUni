using System;

class VowelSum
{
    static void Main()
    {
        //a	e	i	o	u
        //1	2	3	4	5

        
        string word = Console.ReadLine();
        int result = 0;

        for (int i = 0; i < word.Length; i++)
        {
            switch (word[i])
            {
                case 'a': result += 1;
                    break;
                case 'e': result += 2;
                    break;
                case 'i': result += 3;
                    break;
                case 'o': result += 4;
                    break;
                case 'u': result += 5;
                    break;
                
            }
        }
        Console.WriteLine(result);

    }
}

