﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.



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

int temp = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
temp = matrix[0, j];
matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
matrix[matrix.GetLength(0) - 1, j] = temp;
}

System.Console.WriteLine();
PrintMatrix(matrix);


/*Задача 53: Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива.*/
 
// int VariableCreationInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
 
// int[,] filling2DArray(int rowCount, int colCount, int minimalArrayValue, int maximalArrayValue)
// {
//     int[,] array2D = new int[rowCount, colCount];
//     Random rnd = new Random();
//     for (int i = 0; i < array2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2D.GetLength(1); j++)
//         {
//             array2D[i, j] = rnd.Next(minimalArrayValue, maximalArrayValue + 1);
//         }
//     }
//     return array2D;
// }
 
// void print2dArray(int[,] array, string text)
// {
//     System.Console.WriteLine();
//     printColor(text, ConsoleColor.Green);
//     System.Console.WriteLine();
//     System.Console.WriteLine();
//     Console.Write("\t");
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         printColor(i + "\t", ConsoleColor.DarkYellow);
//     }
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         printColor(i + "\t", ConsoleColor.DarkYellow);
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
 
// // Метод изменения цвета консоли и возврат цвета к дефолтному
// void printColor(string information, ConsoleColor color)
// {
//     Console.ForegroundColor = color;
//     Console.Write(information);
//     Console.ResetColor();
// }
 
// int[,] RowColConvert(int[,] array2D)
// {
//     int buff;
//     for (int j = 0; j < array2D.GetLength(1); j++)
//     {
//         buff = array2D[0, j];
//         array2D[0, j] = array2D[array2D.GetLength(0) - 1, j];
//         array2D[array2D.GetLength(0) - 1, j] = buff;
//     }
//     return array2D;
// }
 
 
// int row = VariableCreationInt("Введите количество строк двумерного массива: ");
// int col = VariableCreationInt("Введите количество столбцов двумерного массива: ");
// int min = VariableCreationInt("Введите минимальное значение двумерного массива (целые числа): ");
// int max = VariableCreationInt("Введите максимальное значение двумерного массива (целые числа): ");
// if (min > max)
// {
//     printColor("Минимальное значение массива не может быть больше максимального\n", ConsoleColor.Red);
//     return;
// }
// int[,] array2D = filling2DArray(row, col, min, max);
// print2dArray (array2D, "Вывод сгенерированного массива");
// RowColConvert(array2D);
// print2dArray (array2D, "Вывод изменённого массива");