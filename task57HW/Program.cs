﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

internal class Program
{
    private static void Main(string[] args)
    {
        void FillMatrixWithRandom(int[,] matrix)
        {
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} \t");
                }
                System.Console.WriteLine();
            }
        }

        System.Console.WriteLine("Введите кол-во строк: ");
        int row = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите кол-во столбцов: ");
        int column = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[row, column];
        FillMatrixWithRandom(matrix);
        PrintMatrix(matrix);
        BubbleSort(matrix);
        System.Console.WriteLine();
        PrintMatrix(matrix);



        static void BubbleSort(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        int temp = matrix[i, k];
                        matrix[i, k] = matrix[i, k + 1];
                        matrix[i, k + 1] = temp;
                    }
                }
            }
        }
    }
}
}
   