// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
System.Console.WriteLine("Введите первое число диапозона: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число диапозона: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число элементов в массиве: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num3];

Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(num1,num2);
   System.Console.Write($"[{string.Join("; ", array[i])}]");
}