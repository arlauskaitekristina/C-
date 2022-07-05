// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine ("Эта программа принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N");
Console.Write("Введите число для вычисления: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int square = 0;

while (count <= num)
{
    square = count * count;
    Console.WriteLine($"{count, 3} -> {square, 3} ");
    count++;
}