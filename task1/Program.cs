Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.Write($"{number1} is quater {number2}");
}
else
{
    Console.Write($"{number1} isn't quater {number2}");
}
