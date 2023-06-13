// Напишите программу, которая будет принимать на вход два числа и выводить, является 
// ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


System.Console.Write("Введите первое число для проверки: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число для проверки: ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 % num2 == 0)
{ System.Console.WriteLine($"Число {num1} кратно {num2}"); }
else

{ System.Console.WriteLine($"Остаток равен {num1%num2}"); }