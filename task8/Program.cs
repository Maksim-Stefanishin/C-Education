Console.Write("Input number: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 2;
while (count <= n)
{
        Console.Write($"{(count++)} ");
        count++;
}    