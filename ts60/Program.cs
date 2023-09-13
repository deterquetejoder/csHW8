using System;

public class Program
{
    public static void Main()
    {
        int[][][] array = new int[2][][];

        for (int i = 0; i < 2; i++)
        {
            array[i] = new int[2][];

            for (int j = 0; j < 2; j++)
            {
                array[i][j] = new int[10];

                for (int k = 0; k < 10; k++)
                {
                    array[i][j][k] = (i * 10) + j + k;
                }
            }
        }

        foreach (int[][] row in array)
        {
            Console.WriteLine();
            foreach (int[] column in row)
            {
                foreach (int value in column)
                {
                    Console.Write($"{value}, ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}