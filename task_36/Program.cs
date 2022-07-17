//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Эта программа задаёт одномерный массив, заполненный случайными числами, и находит сумму элементов, стоящих на нечётных позициях.");
Console.Write("Введите размер массива: ");
int intsize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    
    }
}

int SumNum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

int[] array = CreateArrayRndInt(intsize, min, max); 
PrintArr(array);
int result = SumNum(array);
Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");

