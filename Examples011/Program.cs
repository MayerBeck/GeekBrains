void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int positoin = 0;
    while(positoin < count)
    {
        Console.WriteLine(col[positoin]);
        positoin++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int positoin = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            positoin = index;
            break;
        }
        index++;
    }
    return positoin;
}
int[] array = new int[20];

FillArray(array);   //Метод заполнения массива
PrintArray(array);  //Метод печати на экран
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);