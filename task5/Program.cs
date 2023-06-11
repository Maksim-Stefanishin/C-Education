Console.Write("Input number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = -number;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}