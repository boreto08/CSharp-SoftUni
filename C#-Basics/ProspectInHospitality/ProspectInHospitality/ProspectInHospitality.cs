using System;

class ProspectInHospitality
{
    static void Main()
    {
    

        decimal b = decimal.Parse(Console.ReadLine());
        decimal r = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal t = decimal.Parse(Console.ReadLine());
        decimal o = decimal.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal u = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        decimal sum = 0m;
        sum += (1500.04M * b) + (2102.10m * r) + (1465.46m * c) + (2053.33m * t) + (3010.98m * o) + (n * u) + s;
        Console.WriteLine("The amount is: {0:f2} lv.",sum);
        if (m >=sum)
        {
            Console.WriteLine("YES \\ Left: {0:f2} lv.",m-sum);
        }
        else
        {
            Console.WriteLine("NO \\ Need more: {0:f2} lv.",sum-m);
        }

       

    }
}

