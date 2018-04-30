using System;
//using System.Text;

class NakovsMatching
{
    static void Main()
    {
        string aWord = Console.ReadLine();
        string bWord = Console.ReadLine();
        int nakovs = int.Parse(Console.ReadLine());

        for (int i = 0; i < aWord.Length - 1; i++)
        {
            string aLeft = aWord.Substring(0,i+1);
            string aRight = aWord.Substring(i+1, aWord.Length-1-i);
            for (int j = 0; j < bWord.Length - 1; j++)
            {
                string bLeft = bWord.Substring(0, j+1);
                string bRight = bWord.Substring(j+1,bWord.Length-1 - j);
                int weight = Math.Abs( (CalculateWeight(aLeft) * CalculateWeight(bRight)) 
                    - ( CalculateWeight(aRight) * CalculateWeight(bLeft) ) );
                if ( weight < nakovs )
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs",aLeft,aRight,bLeft,bRight,weight);
                }
                
            }
        }
    }

    static int CalculateWeight(string word)
    {
        int sum = 0;
        for (int i = 0; i < word.Length; i++)
        {
            sum += (int)word[i];
        }
        return sum;
    }
}

