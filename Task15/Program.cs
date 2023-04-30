// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = WeekendsDays(num);
Console.Write(result ? "Этот день недели выходной" : "Этот день недели не выходной");

bool WeekendsDays (int num)
{
    return num == 7;
}