﻿// Задача 67: Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int SumDigital(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number%10 + SumDigital(number/10);
}


System.Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Sum of digits is: {SumDigital(number)}");