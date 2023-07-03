//Задача 59:


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


// int SumOddElemet (int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                sum = sum + matrix[i, j];
//             }
//         }
//     }
// return sum;
// }
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int [,] DeleteMinColRow (int [,] matrix)
{
  int [,] newMatrix = new int [matrix.GetLength(0)-1, matrix.GetLength(1)-1];
  int min = matrix [0,0];
  int minCol = 0;
  int minRow = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] < min)
      {
        min= matrix [i,j];
        minRow=i;
        minCol=j;

      }
    }
  }

  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      if (i<minRow&&j<minCol)
      {
      newMatrix[i,j]=matrix [i,j];
      }
      else if (i<minRow && j>=minCol)
      {
        newMatrix[i,j]=matrix [i,j+1];
      }
      else
      {
        newMatrix[i,j]=matrix [i+1,j+1];
      }

   
    }
    

  }
  
return newMatrix;
}

System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(DeleteMinColRow(matrix));

