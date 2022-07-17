// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Эта программа считает, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Сколько чисел вы хотите ввести? ");
int numM = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numM];

void PrintArray(int numM)
{
for (int i = 0; i < numM; i++)
  {
    Console.Write($"Введите {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int SearchElem(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

PrintArray(numM);
Console.WriteLine($"Количество чисел больше нуля: {SearchElem(array)} ");
