// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Эта программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Mult(int numA, int numB)
{
    int mult = 1;
    for (int i = 1; i <= numB; i++)
{
    mult = mult * numA;
}
    return mult;

}
int result = Mult(numA, numB);

if (numB < 0) Console.WriteLine("Эта программа работает только с натуральными степенями");
else
    Console.WriteLine("Ответ: " + result);
