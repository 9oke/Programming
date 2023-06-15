// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

void CreateArray()
{
    int[,] matrix1 = new int[,]
    {
        { 1, 2, 3 },
        { 4, 5, 6 }
    };

    int[,] matrix2 = new int[,]
    {
        { 7, 8 },
        { 9, 10 },
        { 11, 12 }
    };

    Console.WriteLine("Первая матрица: ");
    PrintMatrix(matrix1);
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(matrix2);

    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
        return;
    }

    int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);

    Console.WriteLine("Произведение матриц:");
    PrintMatrix(productMatrix);
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;

            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }

            result[i, j] = sum;
        }
    }

    return result;
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
}

CreateArray();

