// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.Write("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

string[] quaters = { "x > 0; y > 0",
                    "x < 0; y > 0",
                    "x < 0; y < 0",
                    "x > 0; y < 0"
};

if (quater >= 1 && quater <= 4)
{
    System.Console.WriteLine(quaters[quater - 1]);
}
else
{
    System.Console.WriteLine("Такого номера четверти не бывает");
}