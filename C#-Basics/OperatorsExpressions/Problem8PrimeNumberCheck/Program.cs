using System;

class Program
{
    static void Main()
    {
        int num  = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(num);
        bool prime = true;
        if(num > 1)
        {
            while (divider <= maxDivider)
            {
                if (num % divider == 0 )
                {
                    prime = false;
                }
                divider++;
            }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
        else 
        {
            prime = false;
            Console.WriteLine("Not Prime");
        }
        

    }
}

