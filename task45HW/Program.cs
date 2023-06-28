//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3





int[] fillingArray(int arrayLength)
{
    int[] array = new int[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(System.Console.ReadLine());
    }
    return array;
}


System.Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите числа: ");
int[] array = fillingArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");

int counter = 0;

for (int i = 0; i < length; i++)
{
    if(array[i] > 0)
    {
        counter += 1;
    }
}

System.Console.WriteLine($"Количество чисел больше 0 = {counter}");