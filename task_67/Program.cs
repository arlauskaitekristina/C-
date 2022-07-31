// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());
int sum = NaturalNumber(n, 0);
Console.WriteLine(sum);

int NaturalNumber(int n, int sum)
{
    sum = sum + n % 10;
    if (n / 10 == 0) return sum;
    else
    {
        return NaturalNumber (n / 10, sum);
    }
}
