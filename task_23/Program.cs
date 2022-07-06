// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Эта программа принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N ");
Console.Write("Введите число для вычисления: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int square = 0;

while (count <= num)
{
    square = count * count * count;
    Console.WriteLine($"{count,3} -> {square,3} ");
    count++;
}
