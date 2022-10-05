// Создание двумерного массива (так еще возможно задавать многомерный массив)

string[,] table = new string[2, 5]; //[строка, столбец]
//String.Empty
//table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
//table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]
  
/* table[1, 2] = "слово"; // обращение к конкретному эл-ту

for (int rows = 0; rows < 2; rows++)  //количество строк
{
    for (int columns = 0; columns < 5; columns++) //количество солбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //количество строк 
    {
        for (int j = 0; j < matr.GetLength(1); j++) //количество солбцов
        {
        Console.Write($"-{table[i, j]}- ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  //количество строк 
    {
        for (int j = 0; j < matr.GetLength(1); j++) //количество солбцов
        {
        matr[i,j] = new Random().Next(1,10); // по матем получается полуинтервал [1, 10)
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
