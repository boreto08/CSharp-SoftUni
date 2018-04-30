using System;

class OddEven
{
    static void Main()
    {
        
        string sequance = Console.ReadLine();
        string[] array= sequance.Split(' ');
        int productOdd = 1;
        int productEven = 1;
        for (int i = 0; i < array.Length; i++)
        {
            int element = int.Parse(array[i]);

            if (i % 2 ==0)
            {
                productEven *= element;
            }
            else
            {
                productOdd *= element;
            }
        }
        if (productOdd==productEven)
        {
            Console.WriteLine("Yes!");
            Console.WriteLine("Product = {0} ", productOdd);
        }
        else
        {
            Console.WriteLine("No!");
            Console.WriteLine("Odd Product = {0} ",productOdd);
            Console.WriteLine("Even Product = {0} ",productEven);
        }
    }
}

