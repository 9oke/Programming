// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void CreateArray()
{
    int[,] matrix = {
        {5, 8, 3, 2},
        {9, 1, 6, 4},
        {7, 2, 9, 3}
    };

    Console.WriteLine("Массив: ");
    PrintMatrix(matrix);

    SortRowsDescending(matrix);

    Console.WriteLine("Измененный массив:");
    PrintMatrix(matrix);
}

void SortRowsDescending(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int[] tempArray = new int[columns];

        for (int j = 0; j < columns; j++)
        {
            tempArray[j] = matrix[i, j];
        }

        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = tempArray[j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

CreateArray();



