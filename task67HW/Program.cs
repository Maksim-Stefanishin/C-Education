// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum(int x, int y)
{
    if(x == y)
    {
        return y;
    }
    return y+SumNum(x, y-1);
}


System.Console.WriteLine("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0)
{
    System.Console.WriteLine("Incorrect number");
}
else System.Console.WriteLine(SumNum(M,N));
