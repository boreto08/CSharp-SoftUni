using System;
using System.Collections.Generic;

class EncryptedMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<int> inputToNumber = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            int currentNum = (int)input[i] % 10;
            inputToNumber.Add(currentNum);
        }
        //encrypt Number
        List<int> encryptedNum = new List<int>();
        for (int j = 0; j < inputToNumber.Count; j++)
        {
            int currentNum = inputToNumber[j];
            if (currentNum % 2 == 0)
            {
                encryptedNum.Add(currentNum * currentNum);
            }
            else
            {
                if (j == 0)
                {
                   currentNum += inputToNumber[j + 1];
                   encryptedNum.Add(currentNum);
                }
                else if (j == inputToNumber.Count - 1)
                {
                    currentNum += inputToNumber[j - 1];
                    encryptedNum.Add(currentNum);
                }
                else
                {
                    currentNum += inputToNumber[j + 1] + inputToNumber[j - 1];
                    encryptedNum.Add(currentNum);
                }
            }
        }
        string encryptedNumber = string.Join("",encryptedNum.ToArray());
        string diagonalDirection = Console.ReadLine();
        int[,] matrix = new int[encryptedNumber.Length, encryptedNumber.Length];
        if (diagonalDirection == "\\" )
        {
            int startRow = 0;
            int startCol = 0;
            int index = 0;
            while ((startRow < matrix.GetLength(0)) && (startCol < matrix.GetLength(1)))
	        {
	           matrix[startRow,startCol] = int.Parse(encryptedNumber[index].ToString());
                startRow++;
                startCol++;
                index++;
	        }
            
        }
        else if(diagonalDirection == "/")
        {
            int startRow = 0;
            int startCol = matrix.GetLength(1)-1;
            int index = 0;
            while ((startRow < matrix.GetLength(0)) && (startCol >= 0))
            {
                matrix[startRow, startCol] = int.Parse(encryptedNumber[encryptedNumber.Length - 1  - index].ToString());
                startRow++;
                startCol--;
                index++;
            }
        }
        //print matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
			    Console.Write(matrix[row,col]+ " ");
			}
            Console.WriteLine();
		}

        
        
    }
}

