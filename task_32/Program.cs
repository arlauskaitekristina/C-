// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Эта программа заменяет элементы массива: положительные на соответствующие отрицательные, и наоборот");
Console.WriteLine("Введите размер массива: ");
int intsize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
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

int [] SwapElem (int[] array)
{
    int [] resArr = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resArr[i] = array[i] * -1;
    }
    return resArr;
}

int[] genarr = CreateArrayRndInt( intsize, min, max);
int [] swapArr = SwapElem (genarr);

PrintArr(genarr);
PrintArr(swapArr);