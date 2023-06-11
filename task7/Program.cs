Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
System.Console.Write($"{number} -> {result}");