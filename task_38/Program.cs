// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Эта программа задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");

double[] CreateNum = new double[7];
  for (int i = 0; i < CreateNum.Length; i++ )
  {
    CreateNum[i] = new Random().Next(1, 100);
    Console.Write(CreateNum[i] + " ");
  }

double maxNum = CreateNum[0];
double minNum = CreateNum[0];

  for (int i = 1; i < CreateNum.Length; i++)
  {
    if (maxNum < CreateNum[i])
    {
      maxNum = CreateNum[i];
    }
        if (minNum > CreateNum[i])
    {
      minNum = CreateNum[i];
    }
  }

  double pos = maxNum - minNum;

  Console.WriteLine($"\nРазница между между максимальным и минимальным элементами: {pos}");
