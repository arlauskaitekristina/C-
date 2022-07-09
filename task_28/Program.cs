// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Эта программа принимает на вход число N и выдаёт произведение чисел от 1 до N");
Console.Write("Введите число для подсчета: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int res = 1;
int start = 1;

while (start <= numberN)
{
    res *= start;
    start++;
}
Console.WriteLine(res);


// int Mult(int num)
// {
//     int mult = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         mult = mult * i;
//     }
//     return mult;
// }
// int result = Mult(numberN);
// Console.WriteLine($"Произведение чисел от 1 до {numberN} = {result}");

// int x = 1;
// int Count(int number)
// {
//     for (int i = 1; i <= number; i++)
//     x = i * x;
//     return x;
// }
// int result = Count(num);
// Console.WriteLine(result);




