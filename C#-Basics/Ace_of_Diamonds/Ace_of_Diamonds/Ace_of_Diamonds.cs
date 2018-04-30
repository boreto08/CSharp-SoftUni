using System;

class Ace_of_Diamonds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('*',n));
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("*{0}{1}{0}*",new string('-',(n/2)-i-1),new string('@',n/n+(2*i)));
        }
        ////int checkI = (n / 2) - 1;
        int middle = n / 2;
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            Console.WriteLine("*{0}{1}{0}*", new string('-',(n/n)+i),new string('@',(n-4)-(2*i)));
        }
        Console.WriteLine(new string('*',n));
        
    }
}

