// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

void CreateArray()
{
    int[,] matrix = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

    Console.WriteLine("Исходный массив:");
    PrintMatrix(matrix);

    if (CanTranspose(matrix))
    {
        int[,] transposedMatrix = Transpose(matrix);

        Console.WriteLine("Массив с замененными строками и столбцами:");
        PrintMatrix(transposedMatrix);
    }
    else
    {
        Console.WriteLine("Невозможно заменить строки на столбцы.");
    }
}

bool CanTranspose(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] Transpose(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] transposedMatrix = new int[columns, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            transposedMatrix[j, i] = matrix[i, j];
        }
    }

    return transposedMatrix;
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
