﻿// Задача 69: Напишите программу, которая на вход
//  принимает два числа A и B, и возводит число А в целую
//   степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowNum(int x, int y)
{
    if(y == 0)
    {
        return 1;
    }
    return x*PowNum(x, y-1);
}




System.Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(PowNum(numberA, numberB));