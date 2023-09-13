using System;

class SpiralMatrix
{
    static void Main()
    {
        int rows = 4;
        int columns = 4;
        int[,] matrix = new int[rows, columns];
        int count = 1;

        int rowStart = 0;
        int rowEnd = rows - 1;
        int colStart = 0;
        int colEnd = columns - 1;

        while (count <= rows * columns)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = count++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = count++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = count++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = count++;
            }
            colStart++;
        }

        // Print the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}