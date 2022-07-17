// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");

Console.WriteLine("Введите размер массива: ");
double intsize = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] CreateArr()
{
    array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next();
    }
    return array;
}

void PrintArr(double[] array, int Round = 2)
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");

    }
}

double SearchElem (double[]array) 
{
double max=array[0];
double min=array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }

    return  max - min;
}
double[] arr = CreateArr(5, );
PrintArr(arr);
double result = SearchElem (arr);
Console.WriteLine($"\nРазница между между максимальным и минимальным элементами: {result}");
