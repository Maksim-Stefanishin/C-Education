Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n%2==0)
{
    Console.Write($"{n} is even");
}
else if(n%2!=0)
{
    Console.Write($"{n} is odd");
}