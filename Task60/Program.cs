// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

void CreateArray()
{
    int[,,] array = GenerateArray();

    PrintArrayWithIndices(array);
}

int[,,] GenerateArray()
{
    int[,,] array = new int[10, 10, 10];
    int count = 10;
    int num = 10;

    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            for (int k = 0; k < 10; k++)
            {
                array[i, j, k] = num++;
                if (num == 100) num = 10;
            }
        }
    }

    return array;
}

void PrintArrayWithIndices(int[,,] array)
{
    int dim1 = array.GetLength(0);
    int dim2 = array.GetLength(1);
    int dim3 = array.GetLength(2);

    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] = {array[i, j, k]}");
            }
        }
    }
}

CreateArray();