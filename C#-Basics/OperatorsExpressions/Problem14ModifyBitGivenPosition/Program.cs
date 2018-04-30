using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int preparation=0;
        if (v == 0 )
        {
             preparation = number & ~(1 << pos); 
        }
        else
        {
            preparation = number | (1 << pos);
        }
        Console.WriteLine(preparation);

    }
}
