int SetArraySize()
{
    System.Console.Write("Введите длину массива:");
    int arrSize = Convert.ToInt32(Console.ReadLine());

    return arrSize;
}

int countItems = SetArraySize();