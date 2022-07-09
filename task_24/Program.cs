// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Эта программа принимает на вход число (А) и выдаёт сумму чисел от 1 до А");
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= a; i++)
// {
//     sum = sum + 1;

//     if (i < a)
//     {
//         Console.Write($"{i} + ");
//     }

//     else
//     {
//         Console.Write($"{i} = ");
//     }

// }
// Console.WriteLine($"{sum}");

// Решение через метод:

int Sum(int num)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int res = Sum(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {res}");



