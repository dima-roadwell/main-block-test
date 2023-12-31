﻿int SetArraySize()
{
    System.Console.Write("Введите длину массива: ");
    int arrSize = Convert.ToInt32(Console.ReadLine());

    return arrSize;
}

string[] FillArray(int arrSize) // Консоль не отображает кириллицу
{
    string[] arr = new string[arrSize];

    for(int i = 0; i < arrSize; i++)
    {
        System.Console.Write($"Введите элемент '{i}': ");
        string arrValue = Console.ReadLine();
        arr[i] = arrValue;
    }

    return arr;
}

void PrintArr(string[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}; ");
    }
}

int countItems = SetArraySize();
string[] arr = FillArray(countItems);

string[] newArr = new string[countItems];
int newArrIndex = 0;

for(int i = 0; i < countItems; i++)
{
    if(arr[i].Length <= 3)
    {
        newArr[newArrIndex] = arr[i];
        newArrIndex++;
    }
}

PrintArr(arr);
System.Console.WriteLine();

Array.Resize(ref newArr, newArrIndex);
PrintArr(newArr);