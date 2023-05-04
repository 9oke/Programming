// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

Square(num);

void Square (int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} {count * count}");
        count++;
    }
}