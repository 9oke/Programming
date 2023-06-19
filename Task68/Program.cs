// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

MessageOfTheUser();

void MessageOfTheUser()
{
    Console.WriteLine("Введите значения m и n:");

    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());

    int result = Ackermann(m, n);
    Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n}: {result}");
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
