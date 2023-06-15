// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Random random = new Random();
int size = 4;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = random.Next(100, 1000);
}

Console.WriteLine("Массив случайных трёхзначных чисел: ");
Console.Write("[");

foreach (int number in array)
{
    Console.Write(number + ",");
}
Console.WriteLine("]");

int count = EvenNumbers(array);

int EvenNumbers(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Количество чётных чисел: " + count);
