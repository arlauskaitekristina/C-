string[] myArray = new string[5] { "hello", "2", "pink", "computer", ":)" };
string[] finResult = new string[myArray.Length];
int count = 0;

string[] ResultArray(string[] myArray, string[] finResult)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            finResult[count] = myArray[i];
            count++;
        }
    }
    return finResult;
}

void PrintArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
    Console.WriteLine();
}

string[] arrayResult = ResultArray(myArray, finResult);
PrintArray(finResult);