// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Эта программа вычисляет функцию Аккермана с помощью рекурсии, два неотрицательных числа M и N задаются пользователем");
Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckerFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckerFunction(m - 1, 1);
    else
        return AckerFunction(m - 1, AckerFunction(m, n - 1));
}

if (m < 0 || n < 0) Console.WriteLine("M и N должны быть неотрицательными");
else Console.WriteLine("Результат вычисления функции: " + AckerFunction(m, n));