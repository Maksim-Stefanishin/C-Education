Console.Write("Input number: ");
int number =Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 0;
while(count<=2* number)
{
    Console.Write($"{-number + count++}, ");
}