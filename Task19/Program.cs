// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int originalNum = num;

Palindrome(num);

void Palindrome (int num)
{
    int digit5 = num % 10;
    num /= 10;
    int digit4 = num % 10;
    num /= 10;
    int digit3 = num % 10;
    num /= 10;
    int digit2 = num % 10;
    num /= 10;
    int digit1 = num % 10;
    bool isPalindrome = (digit1 == digit5) && (digit2 == digit4);
    if (isPalindrome)
    {
        Console.WriteLine($"{originalNum} - это палиндром!");
    }
    else
    {
        Console.WriteLine($"{originalNum} - это не палиндром.");
    }
}