using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyTargetedCell
{
    class MultiplyTargetedCell
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);
            var cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowIndex = cordinates[0];
            int colIndex = cordinates[1];
            int targetValue = matrix[rowIndex, colIndex];
            CalculateTargetCell(matrix, cordinates);
            CalculateNeighboringCells(matrix, cordinates,targetValue);
            
            PrintMatrix(matrix);
        }

        private static void CalculateNeighboringCells(int[,] matrix, int[] cordinates,int targetValue)
        {
            int rowIndex = cordinates[0];
            int colIndex = cordinates[1];
            int targetCellValue = targetValue;
 
            for (int row = -1; row <= 1; row++)
            {
                for (int col = -1; col <= 1; col++)
                {
                    try
                    {
                        if (row == 0 && col == 0)
                        {
                            continue;
                        }
                        matrix[rowIndex + row, colIndex + col] *= targetCellValue;

                    }
                    catch (Exception)
                    {

                        continue;
                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void CalculateTargetCell(int[,] matrix, int[] cordinates)
        {
            int rowIndex = cordinates[0];
            int colIndex = cordinates[1];
            int targetCellValue = matrix[rowIndex, colIndex];
            int sum = 0;
            for (int row = -1; row <= 1; row++)
            {
                for (int col = -1; col <= 1; col++)
                {
                    try
                    {
                        if (row == 0 && col == 0)
                        {
                            continue;
                        }
                        sum += matrix[rowIndex + row, colIndex + col];

                    }
                    catch (Exception)
                    {

                        continue;
                    }
                }
            }

            targetCellValue = targetCellValue * sum;
            matrix[rowIndex, colIndex] = targetCellValue;
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var nums = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < nums.Length; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }
        }
    }
}
