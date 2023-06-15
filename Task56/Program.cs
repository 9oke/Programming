// Задача 56: Задайте двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.

void CreateArray()
{
    int[,] array = new int[,]
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    int minSumRow = FindRowWithMinSum(array);

    Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumRow);
}

int FindRowWithMinSum(int[,] array)
{
    int minSumRow = 0;
    int minSum = int.MaxValue;

    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;

        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }

    return minSumRow;
}

CreateArray();
