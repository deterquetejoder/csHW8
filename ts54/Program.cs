// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
//  убыванию элементы каждой строки двумерного массива.


            int[,] array = { 
                 { 5, 3, 1 },
                 { 4, 2, 7 },
                 { 9, 7, 6 },
            };

            foreach (var row in array)
            {
                SortRow(row);
            }

            PrintArrays(array);
        

        static void SortRow(int[] row)
        { 
            Array.Sort(row); 
            Array.Reverse(row);  
        }


        static void PrintArrays(int[,] arrays)
        {  
            foreach(var array in arrays)
            {  
                Console.WriteLine(string.Join(" ", array));
            }  
         } 