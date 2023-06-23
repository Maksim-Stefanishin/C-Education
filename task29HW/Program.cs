// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
int[] b = new int[str.Length];
int sum = 0;
for( int i = 0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
     sum = sum + b[i];
}

System.Console.WriteLine($"Сумма цифр числа {number}= {sum} ");



