using System;

class DetectiveBoev
{
    static void Main()
    {
        string secretWord = Console.ReadLine();
        string encryptedMess = Console.ReadLine();
        int mask = SumUntilOneDigit(secretWord);
        int chCode = 0;
        for (int i = 0; i < encryptedMess.Length; i++)
        {
            
                if ((int)encryptedMess[encryptedMess.Length - 1 - i] % mask == 0)
                {
                    chCode = (int)encryptedMess[encryptedMess.Length - 1 - i] + mask;
                    Console.Write((char)chCode);
                }
                else if ((int)encryptedMess[encryptedMess.Length - 1 - i] % mask != 0)
                {
                    chCode = (int)encryptedMess[encryptedMess.Length - 1 - i] - mask;
                    Console.Write((char)chCode);
                }
            
            
        }
        Console.WriteLine();
    }
    static int SumUntilOneDigit(string SecrectWord)
    {
        int sum = 0;
        int result = 0;
        foreach (var ch in SecrectWord)
        {
            sum += (int)ch;
        }
        while (sum > 10 )
        {
            result = 0;
            while (sum != 0)
            {

                int currentNum = sum % 10;
                sum /= 10;
                result += currentNum;
                
            }
            sum = result;

        }
        return result;
 
    }
}

