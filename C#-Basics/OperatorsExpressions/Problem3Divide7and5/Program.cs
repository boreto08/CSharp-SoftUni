using System;

class Program
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        bool dividable = true;

        if (firstNum % 5 == 0 && firstNum % 7 == 0 )
        {
            Console.WriteLine(dividable);
        }
        else
        {
            dividable = false;
            Console.WriteLine(dividable);
        }


    }
}

