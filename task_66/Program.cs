// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Эта программа задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N включительно.");
Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNatural(int m, int n)
{
    if (m < n) return m + SumNatural(++m, n);
    else return n;
}
if (m > n) Console.WriteLine("Число M должно быть меньше или равно N");
else Console.WriteLine("Сумма натуральных чисел в диапазоне от M до N включительно: " + SumNatural(m, n));