Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] sortArray = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    sortArray[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", sortArray) + "]");
Console.WriteLine();

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return array;
    }

    int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

    QuickSort(array, minIndex, pivotIndex - 1);

    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}

int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivot = minIndex - 1;

    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }

    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);

    return pivot;
}

void Swap(ref int leftItem, ref int rightItem)
{
    int temp = leftItem;

    leftItem = rightItem;

    rightItem = temp;
}

Console.WriteLine("Конечный массив: [" + string.Join(", ", sortedArray) + "]");
Console.ReadLine();