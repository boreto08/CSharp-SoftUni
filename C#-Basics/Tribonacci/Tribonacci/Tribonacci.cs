using System;
using System.Numerics;
class Tribonacci
{
    static void Main()
    {
        BigInteger e1 =BigInteger.Parse(Console.ReadLine());
        BigInteger e2 =BigInteger.Parse(Console.ReadLine());
        BigInteger e3 =BigInteger.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        BigInteger tribonSum=0;
        if (N==1)
        {
            Console.WriteLine(e1);
        }
        else if (N == 2)
        {
            Console.WriteLine(e2);
        } 
        else if (N == 3)
        {
            Console.WriteLine(e3);
        }
        else 
	    {
        for (int i = 3; i < N; i++)
			{
			    tribonSum=e1+e2+e3;
                e1=e2;
                e2=e3;
                e3=tribonSum;
			}
             Console.WriteLine(tribonSum);
	    }
        
       

    }
}

