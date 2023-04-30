// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 12 мин

int num = new Random().Next(100, 1000); // (100, 999 + 1)
Console.WriteLine($"Случайное число из отрезка от 100 до 999 --> {num}");
int result = RemoveSecondDigit(num);
Console.WriteLine($"{num} --> {result}");

int RemoveSecondDigit (int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int needDigit = firstDigit * 10 + thirdDigit;
    return needDigit;
}