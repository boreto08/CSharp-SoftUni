using System;


class Program
{
    static void Main()
    {
        uint firstNum = uint.Parse(Console.ReadLine());
        uint secNum = uint.Parse(Console.ReadLine());
        
        ulong result = 0l;
        if (firstNum >= secNum)
        {
            for (int i = 32 - 1; i >= 0; i-- )
            {
                result = (result << 1) | ((firstNum >> i) & 1);
                result = (result << 1) | ((secNum >> i) & 1);;
                
	            
            }
        }
        else
        {
            for (int i = 32 - 1; i >= 0; i-=2)
            {
                result = (result << 1) | ((firstNum >> i) & 1);
                result = (result << 1) | ((firstNum >> i - 1) & 1);
                result = (result << 1) | ((secNum >> i) & 1);
                result = (result << 1) | ((secNum >> i - 1) & 1);
                
            }
        }

       
        
        Console.WriteLine(result);
        
    }
}

