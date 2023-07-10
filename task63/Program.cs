void NaturalNumbers(int M, int N)
{    
    if (N == M)    
    {        
        System.Console.WriteLine($"{N}");
        return;
    }
    NaturalNumbers(M, N - 1);
    System.Console.WriteLine($"{N}");NaturalNumbers(M, N);
}
System.Console.WriteLine("Input number 1: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number 2: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNumbers( M,  N);