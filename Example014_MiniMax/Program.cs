// сортировка массива от минимального эл-та к максимальному

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};    //объявили массив

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");   // вывод элементов массива через пробел
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++) // надо сделать от длины -1, чтобы искусственно выравнять длину массива
 {
 int minPosition = i;

for (int j = i + 1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;
}

 int temporary = array[i];
 array[i] = array[minPosition]; //обмен элементами
 array[minPosition] = temporary;
 }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);