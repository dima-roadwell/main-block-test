int SetArraySize()
{
    System.Console.Write("Введите длину массива:");
    int arrSize = Convert.ToInt32(Console.ReadLine());

    return arrSize;
}

string[] FillArray(int arrSize)
{
    string[] arr = new string[arrSize];

    for(int i = 0; i < arrSize; i++)
    {
        string arrValue = Console.ReadLine();
        arr[i] = arrValue;
    }

    return arr;
}

int countItems = SetArraySize();
string[] arr = FillArray(countItems);