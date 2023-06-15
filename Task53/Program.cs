//  Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
 
void CreateArray()
{
    int[,] array = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    for (int j = 0; j < cols; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }

    Console.WriteLine("Измененный массив:");
    PrintArray(array);
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);
