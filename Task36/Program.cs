// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Random random = new Random();
int size = 4; 
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = random.Next(1, 100);
}

Console.WriteLine("Массив случайных трёхзначных чисел: ");
Console.Write("[");

foreach (int number in array)
{
    Console.Write(number + ",");
}
Console.WriteLine("]");

int sum = SumElements(array);

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.WriteLine("Сумма элементов на нечётных позицияц: " + sum);