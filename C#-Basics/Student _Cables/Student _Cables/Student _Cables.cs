using System;

class Student_Cables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());
        int sum = 0;
        int countUnder20Cm = 0;
        for (int i = 0; i < numberOfCables; i++)
        {
            int size = int.Parse(Console.ReadLine());
            string mesure = Console.ReadLine();
            if (mesure != "centimeters")
            {
                size = ToCm(size);
            }
            
            if (size < 20)
	        {
                countUnder20Cm++;
		        continue;
	        }
            sum += size;
        }
        sum -= (numberOfCables - 1-countUnder20Cm) * 3;
        int createdStuCables = sum / 504;
        int remainder = sum - 504 * createdStuCables;
        Console.WriteLine(createdStuCables);
        Console.WriteLine(remainder);
    }

    static int ToCm(int Size)
    {
        return Size * 100;
    }
}

