void FillArray(int[] collection)  //метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)  //метод печати массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)  //метод нахождения индекса числа из массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  //если элемента нет в массиве, то будет выводить -1, а не позицию

    while (index < count)
    {
       if(collection[index] == find)
       {
        position = index;
        break;
       }
        index++;
    }
    return position;

}

int[] array = new int[10];

FillArray(array);
//array[4] = 4; дорисовали для показателя работы оператора break
//array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 5);
Console.WriteLine(pos);
