// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



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

int min = matrix[0, 0];
int max = matrix[0, 0];
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (min > matrix[i, j])
{
min = matrix[i, j];
}
if (max < matrix[i, j])
{
max = matrix[i, j];
}

}
}

for (int k = min; k <= max; k++)
{
count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] == k)
{
count++;
}
}
}
if (count > 0)
{
System.Console.WriteLine($"Кол-во повторений для {k} = {count}");
}
}
// // Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// // 1, 2, 3 
// // 4, 6, 1 
// // 2, 1, 6
// // 1 встречается 3 раза 
// // 2 встречается 2 раз 
// // 3 встречается 1 раз 
// // 4 встречается 1 раз 
// // 6 встречается 2 раза
 
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
 
// // void Dic(int[,] array2D)
// // {
// //     int arrayValue;
// //     int counter;
// //     for (int i = 0; i < array2D.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < array2D.GetLength(1); j++)
// //         {
// //             arrayValue = array2D[i, j];
// //             counter = 0;
// //             for (int n = 0; n < array2D.GetLength(0); n++)
// //             {
// //                 for (int m = 0; m < array2D.GetLength(1); m++)
// //                 {
// //                     if (arrayValue == array2D[n, m]) counter++;
// //                 }
// //             }
// //             System.Console.WriteLine($"{arrayValue} встречается {counter} раз ");
// //         }
// //     }
// // }
 
// void Dic(int[,] array2D, int minArrayValue, int maxArrayValue)
// {
//     for (int n = minArrayValue; n <= maxArrayValue; n++)
//     {
//         int counter = 0;
//         for (int i = 0; i < array2D.GetLength(0); i++)
//         {
//             for (int j = 0; j < array2D.GetLength(1); j++)
//             {
//                 if (n == array2D[i, j]) counter++;
//             }
//         }
//         if (counter !=0)
//         {
//             System.Console.WriteLine($"{n} встречается {counter}");
//         }
//     }    
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
// print2dArray(array2D, "Вывод сгенерированного массива");
 
// Dic(array2D, min, max);
 
 
// // int[] counterArray = 
// // for (int i = 0; i < counterArray.Length; i++)
// // {
// //     if (counterArray[i] != 0)
// //     {
// //         System.Console.WriteLine($"{i} встречается {counterArray[i]} раз");
// //     }
// // }