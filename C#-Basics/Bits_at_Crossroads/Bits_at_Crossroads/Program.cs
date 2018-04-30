using System;

class Program
{
    static void Main()
    {
        int sizeN= int.Parse(Console.ReadLine());
        string[,] matrix = new string[sizeN, sizeN];
        int crossRoads = 0; 
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            string[] cordinates = input.Split();
            int row = int.Parse(cordinates[0]);
            int col = matrix.GetLength(1) - 1 - int.Parse(cordinates[1]);
            int rightRow = 0;
            int rightCol = 0;
            int leftRow = 0;
            int leftCol = 0;
            int rightPosRow = row;
            int rightPosCol = col;
            int leftPosRow = row;
            int leftPosCol = col;
            while (rightPosRow > 0 && rightPosCol < sizeN-1)
            {
                rightPosRow--;
                rightPosCol++;
                rightRow = rightPosRow;
                rightCol = rightPosCol;
            }
            while (leftPosRow > 0 && leftPosCol > 0)
            {
                leftPosRow--;
                leftPosCol--;
                leftRow = leftPosRow;
                leftCol = leftPosCol;
            }
            for (int i = 0; i < sizeN; i++)
            {
                if (matrix[rightRow, rightCol] == "1")
                {
                    crossRoads++;
                }
                else if (matrix[rightRow, rightCol] == null)
                {
                    matrix[rightRow, rightCol] = "1";
                }
                rightRow++;
                rightCol--;
                if (rightRow > sizeN-1 || rightCol < 0)
                {
                    break;
                }
            }
            for (int i = 0; i < sizeN; i++)
            {
                if (matrix[leftRow, leftCol] == "1")
                {
                    crossRoads++;
                }
                else if (matrix[leftRow, leftCol] == null)
                {
                    matrix[leftRow, leftCol] = "1";
                }
                leftRow++;
                leftCol++;
                if (leftRow > sizeN-1 || leftCol > sizeN-1)
                {
                    break;
                }
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == null)
                {
                    matrix[i, j] = "0";
                }
            }
        }
        string numInBinary = null;
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                numInBinary += matrix[row, col]; 
            }
            int number = Convert.ToInt32(numInBinary, 2);
            Console.WriteLine(number);
            numInBinary = null;
        }
        Console.WriteLine(crossRoads);
    }
}

