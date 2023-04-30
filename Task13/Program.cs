// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999) 
{
    int thirdDigit = num % 10;
    Console.WriteLine($"Третья цифра в числе {num} равна {thirdDigit}");
} 
else Console.WriteLine($"В числе {num} нет третьей цифры");