// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArrayWithRandomNumber(int size)
{
   double[] array = new double[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0,5) + rand.NextDouble();
            }
 
            return array;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
     if ( array[i] < min)
     {
        min = array[i] ;
     }
     else if (array[i] > max)
     {
        max = array[i] ;
     }
}
double result = max - min;

System.Console.WriteLine($"Разница между макисмальным и минимальным значением {result} ");

