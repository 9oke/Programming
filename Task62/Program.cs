// Задача 62: Заполните спирально массив 4 на 4.

void CreateArray()
{
    int[,] array = new int[4, 4];

    FillSpiralArray(array);

    PrintArray(array);
}

void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    int num = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = m - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int col = colStart; col <= colEnd; col++)
        {
            array[rowStart, col] = num++;
        }
        rowStart++;

        for (int row = rowStart; row <= rowEnd; row++)
        {
            array[row, colEnd] = num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int col = colEnd; col >= colStart; col--)
            {
                array[rowEnd, col] = num++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int row = rowEnd; row >= rowStart; row--)
            {
                array[row, colStart] = num++;
            }
            colStart++;
        }
    }
}

void PrintArray(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

CreateArray();