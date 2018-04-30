using System;

class Program
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        switch (projectionType)
        {
            case "Premiere":
                Console.WriteLine("{0:f2} leva",rows*cols*12);
                break;
            case"Normal":
                Console.WriteLine("{0:f2} leva", rows * cols * 7.5d);
            break;
            case "Discount" :
            Console.WriteLine("{0:f2} leva", rows * cols * 5);
            break;

            default:
                Console.WriteLine("Wrong input!");
                break;
        }
    }
}

