using System;

class Butterfly
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isStar = true;
        string stars = string.Format("{0}\\ /{0}", new string('*', n - 2));
        string dash = string.Format("{0}\\ /{0}", new string('-', n - 2));
        string starsTwo = string.Format("{0}/ \\{0}", new string('*', n - 2));
        string dashTwo = string.Format("{0}/ \\{0}", new string('-', n - 2));
        for (int i = 0; i < n-2; i++)
        {
            if (isStar)
            {
                Console.WriteLine(stars);
                isStar = false;
            }
            else
            {
                Console.WriteLine(dash);
                isStar = true;
            }
        }
        Console.Write("{0}",new string(' ',n-1));
        Console.WriteLine("@");
        isStar = true;
        for (int i = 0; i < n - 2; i++)
        {
            if (isStar)
            {
                Console.WriteLine(starsTwo);
                isStar = false;
            }
            else
            {
                Console.WriteLine(dashTwo);
                isStar = true;
            }
        }
        

    }
}

