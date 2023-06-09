﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
string num = Console.ReadLine();
string range = Range(num);
Console.WriteLine(range == null ? "Некорректный номер четверти" : range);

string Range (string num)
{
    if(num == "1") return "x > 0, y > 0";
    if(num == "2") return "x < 0, y > 0";
    if(num == "3") return "x < 0, y < 0";
    if(num == "4") return "x > 0, y < 0";
    return null;
}