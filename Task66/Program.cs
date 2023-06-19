// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

MessageOfTheUser();

void MessageOfTheUser ()
{
    Console.WriteLine("Введите значение M:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int n = int.Parse(Console.ReadLine());

    int sum = SumNaturalNumbers(m, n);
    Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", m, n, sum);
}

int SumNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumNaturalNumbers(m + 1, n);
    }
}



