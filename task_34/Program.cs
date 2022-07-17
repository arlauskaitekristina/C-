// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Эта программа задаёт массив заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.");
Console.Write("На сколько элементов задать массив?: ");
int numN = Convert.ToInt32(Console.ReadLine());


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 0) quantity++;
    }
  return quantity;
}

int[] arr = CreateArrayRndInt(numN);
PrintArr(arr);
int result = QuantityPositive(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {result}");