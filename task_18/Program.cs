// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у)

Console.WriteLine("Эта программа по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у)");
Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Coord(int q)
{
    switch (q)
    {
        case 1: return "Диапазон возможных координат x > 0 и y > 0";
        case 2: return "Диапазон возможных координат x < 0 и y > 0";
        case 3: return "Диапазон возможных координат x < 0 и y < 0";
        case 4: return "Диапазон возможных координат x > 0 и y < 0";
        default: return "Введена неккоректная четверть";
    }
}
string result = Coord(quarter);
Console.WriteLine(result);

