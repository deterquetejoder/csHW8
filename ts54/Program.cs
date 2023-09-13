using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 5, 3, 14 },
            { 4, 2, 7 },
            { 2, 7, 10 }
        };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            SortRow(array, i);
        }

        PrintArrays(array);
    }

    static void SortRow(int[,] array, int rowIndex)
    {
        int[] row = new int[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            row[i] = array[rowIndex, i];
        }

        Array.Sort(row);
        Array.Reverse(row);

        for (int i = 0; i < array.GetLength(1); i++)
        {
            array[rowIndex, i] = row[i];
        }
    }

    static void PrintArrays(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}