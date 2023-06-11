Console.Write("Input number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2 && n1 > n3)
{
Console.Write($"Max number {n1}");
}
else if (n2 > n1 && n2 > n3)
{
Console.Write($"Max number {n2}");
}
else if (n3 > n1 && n3 > n2)
{
Console.Write($"Max number {n3}");
}