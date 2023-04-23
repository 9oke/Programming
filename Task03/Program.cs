//Напишите программу.
//1. Которая будет выдавать название дней недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.Write("Введите число от 1 до 7:  ");
int idx = Convert.ToInt32(Console.ReadLine());

if (idx == 1)
{
    
}
if (idx == 2)
{
    Console.Write("Вторник");
}
if (idx == 3)
{
    Console.Write("Среда");
}
if (idx == 4)
{
    Console.Write("Четверг");
}
if (idx == 5)
{
    Console.Write("Пятница");
}
if (idx == 6)
{
    Console.Write("Суббота");
}
if (idx == 7)
{
    Console.Write("Воскресенье");
}
if (idx > 7 || idx < 1)
{
    Console.Write("Номер введен некорректно");
}
