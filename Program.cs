string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i + 1}-ю строку массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


int CountStringSymbols(string[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] ArrayLessThanThree(string[] myArray)
{
    int ArrayLength = CountStringSymbols(myArray);

    string[] resultArray = new string[ArrayLength];

    int j = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            resultArray[j] = myArray[i];
            j++;
        }
    }
    return resultArray;
}

string PrintArray(string[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"\"{array[i]}\"";
            break;
        }
        stringArray += ($"\"{array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

System.Console.Write($"Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateArray(size);
string[] resultArray = ArrayLessThanThree(myArray);
string firstArray = PrintArray(myArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);