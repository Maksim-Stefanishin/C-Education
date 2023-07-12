// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string RecNum (int a, int b)
{    
    if (a <= b) return $"{b} "+ RecNum (a, b-1);
    else return String.Empty;
}

int a = 1;
System.Console.WriteLine("Input number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b <= 1)
{
    System.Console.WriteLine("Incorrect number");
}
else System.Console.WriteLine(RecNum(a,b));


