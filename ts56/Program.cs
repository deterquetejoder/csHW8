// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
static void Main(string[] args)
{
int[,] array = {
 {1, 2, 14},
 {3, 4, 1}, 
 {5, 6, 1}
 };

    int minSum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            index = i;
        }
    }

    Console.WriteLine($"The row having the least sum: {index + 1}");
}
}