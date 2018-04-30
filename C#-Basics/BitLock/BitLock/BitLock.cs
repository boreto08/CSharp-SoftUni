using System;


class BitLock
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[,] matrix = new int[8, 12];
        string[] stringNumbers = input.Split();
        int[] numbers = new int[8];
        for (int k = 0; k < numbers.Length; k++)
        {
            numbers[k] = int.Parse(stringNumbers[k]);
        }
        //Fill matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string numInBinary = Convert.ToString(numbers[i], 2).PadLeft(12, '0');
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j]=int.Parse(numInBinary[j].ToString());
            }
        }
        
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "end")
            {
                break;
            }
            string[] commandArr = command.Split();  
            if (commandArr[0] == "check")
            {
                int countOnesInCol = 0;
                int pos = int.Parse(commandArr[1]);
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, matrix.GetLength(1) - pos -1] == 1)
                    {
                        countOnesInCol++;
                    }
                }
                Console.WriteLine(countOnesInCol);
            }
            else if (commandArr[1] == "right" || commandArr[1] == "left")
	        {
                int row = int.Parse(commandArr[0]);
                int pos =  int.Parse(commandArr[2]);
                int zeroOrOne = 0;
               
                if (commandArr[1] == "right")
                {
                    for (int i = 0; i < pos; i++)
			        {
			            zeroOrOne = numbers[row] & 1;
                        numbers[row] = numbers[row] >> 1;
                        numbers[row] |= zeroOrOne << 11; 

			        }
                   
                }
                else if (commandArr[1] == "left")
	            {
                    zeroOrOne = (numbers[row] >> 11) & 1;
                    numbers[row] = numbers[row] << 1;
                    numbers[row] &= ~(1 << 12);
                    numbers[row] |= zeroOrOne; 
	            }
               
	        }
            


        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]+" ");
        }


        ////Print matrix
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        

        
    }

}

