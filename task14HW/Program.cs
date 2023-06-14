 // Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую
//  цифру этого числа.



Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit3 = (number) % 100 - (number) % 10;
int result = digit3 / 10;
Console.WriteLine($"цифра 2 {result}");