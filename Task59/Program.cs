// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

void CreateArray()
{
    int[,] matrix = {
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4},
        {5, 2, 6, 7}
    };

    int minElement = int.MaxValue;
    int minRowIndex = -1;
    int minColumnIndex = -1;

    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minRowIndex = i;
                minColumnIndex = j;
            }
        }
    }

    if (minRowIndex != -1 && minColumnIndex != -1)
    {
        int[,] modifiedMatrix = new int[rows - 1, columns - 1];
        int modifiedRowIndex = 0;
        int modifiedColumnIndex;

        for (int i = 0; i < rows; i++)
        {
            if (i != minRowIndex)
            {
                modifiedColumnIndex = 0;

                for (int j = 0; j < columns; j++)
                {
                    if (j != minColumnIndex)
                    {
                        modifiedMatrix[modifiedRowIndex, modifiedColumnIndex] = matrix[i, j];
                        modifiedColumnIndex++;
                    }
                }

                modifiedRowIndex++;
            }
        }

        Console.WriteLine("Измененный массив:");
        PrintMatrix(modifiedMatrix);
    }
    else
    {
        Console.WriteLine("Не удалось найти наименьший элемент.");
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