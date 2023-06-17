// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int NumberIndex = 2;
int length = number.Length;
if (length <= 2)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char digit3 = (number)[NumberIndex];
    Console.WriteLine(digit3);
}

