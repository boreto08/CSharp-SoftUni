using System;
using System.Collections.Generic;
using System.Linq;

class TextBombardment
{
    static void Main()
    {
        string text = Console.ReadLine();
        int width = int.Parse(Console.ReadLine());
        double textLenght = Math.Ceiling((double)text.Length/width);
        char[,] matrix = new char[(int)textLenght, width];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row * width + col < text.Length)
                {
                     matrix[row, col] = text[row * width + col];
                }
                else
                {
                    matrix[row, col] = ' ';
                }
            }
        }
        int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //destroying
        for (int i = 0; i < args.Length; i++)
        {
            DestroyColum(matrix, args[i],textLenght);
        }
        //Printig matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
        }
        Console.WriteLine();
    }
    private static void DestroyColum(char[,] Matrix, int colToDestroy, double rows)
    {
        int rowToStart = 0;
        for (int i = 0; i < (int)rows; i++)
        {
            if (Matrix[i,colToDestroy] != ' ')
	        {
                rowToStart = i;
                break;
	        }
        }
        while (Matrix[rowToStart, colToDestroy] != ' ' )
        {
            Matrix[rowToStart, colToDestroy] = ' ';
            rowToStart++;
            if (rowToStart == Matrix.GetLength(0))
            {
                break;
            }
        }
    }
}

