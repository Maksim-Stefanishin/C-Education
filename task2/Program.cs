Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write(($"{number1} > {number2}"));
}
else if (number2 > number1)
{
    Console.Write(($"{number2} > {number1}"));
}