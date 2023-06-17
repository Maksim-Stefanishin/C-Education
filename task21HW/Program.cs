// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using System;
using System.Linq;

public static class Extensions
{
    public static string reverse(this string str) {
        return new string(str.Reverse().ToArray());
    }
}
 
public class Task
{
    public static void Main()
    {
        System.Console.WriteLine("Введите число: ");
        string str = Console.ReadLine()!;;

        string reverse = str.reverse();
        int numericValue;
        bool isNumber = int.TryParse(str, out numericValue);
        if(isNumber == true)
            {
                if(str == reverse)
                {
                    System.Console.Write($"{str} Полигонал");
                }
                else
                {
                    System.Console.Write($"{str} не полигонал");
                }
            }
            else
        {
            System.Console.WriteLine("Не число");
        }

        
    
            }
}
