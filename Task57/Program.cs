// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

void CreateArray()
{
    int[,] matrix = {
        {1, 2, 3},
        {4, 2, 6},
        {7, 8, 2}
    };
    Dictionary<int, int> frequencyDictionary = CreateFrequencyDictionary(matrix);


    Console.WriteLine("Частотный словарь элементов массива:");
    foreach (var entry in frequencyDictionary)
    {
        Console.WriteLine($"Элемент {entry.Key} встречается {entry.Value} раз(а).");
    }
}

Dictionary<int, int> CreateFrequencyDictionary(int[,] matrix)
{
    Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();

    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int element = matrix[i, j];

            if (frequencyDictionary.ContainsKey(element))
            {
                frequencyDictionary[element]++;
            }
            else
            {
                frequencyDictionary[element] = 1;
            }
        }
    }

    return frequencyDictionary;
}

CreateArray();