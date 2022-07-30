// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");

Console.WriteLine("Введите размер массива: ");
int intsize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] CreateArr(int size, int min, int max)
{
    Random rnd = new Random();
    var array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArr(double[] array, int round = 2)
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}

double SearchElem(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }

    return max - min;
}
double[] arr = CreateArr(intsize, m, n);
PrintArr(arr);
double result = SearchElem(arr);
Console.WriteLine($"\nРазница между между максимальным и минимальным элементами: {result}");
