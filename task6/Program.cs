// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n%2==0)
{
    Console.Write($"{n} is even");
}
else if(n%2!=0)
{
    Console.Write($"{n} is odd");
}