// Напишите программу, которая принимает на вход тричисла и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a;
int b;
int c;
bool able;
string answer;

Console.WriteLine("Эта программа принимает на вход тричисла и проверяет, может ли существовать треугольник с сторонами такой длины");
Console.WriteLine("Введите сторону треугольника А: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника В: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника С: ");
c = Convert.ToInt32(Console.ReadLine());

able = CheckAbilityTracl(a, b, c);
answer = ShowAnswer(able);
Console.WriteLine(answer);

bool CheckAbilityTracl(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ShowAnswer(bool ability)
{
    if (ability)
    {
        return "Треугольник возможен";
    }
    else
    {
        return "Треугольник не возможен";
    }
}