//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
System.Console.WriteLine("Введите число 1: ");
int num1  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Multiply(int num1)
{
    int Pow = 1;
    for (int i = 1; i <= num2; i++)
    {
        Pow *= num1; 
    }
    return Pow;
}
System.Console.WriteLine($"Число {num1} в степени {num2} = {Multiply(num1)}");