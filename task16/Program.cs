//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Ведите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) Console.Write("Это понедельник - будний");
if (number == 2) Console.Write("Это вторник - будний");
if (number == 3) Console.Write("Это среда - будний");
if (number == 4) Console.Write("Это четверг - будний");
if (number == 5) Console.Write("Это пятница - будний");
if (number == 6) Console.Write("Это суббота - выходной");
if (number == 7) Console.Write("Это воскресенье - выходной");
if (number > 7) Console.Write("Такого дня не существует");
if (number <= 0) Console.Write("Такого дня не существует");