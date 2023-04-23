// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if(num1 ==  num2 * num2)
{
Console.Write($"Число {num1} = квадрату числа {num2}");
}
else 
{
Console.Write($"Число {num1} не равно квадрату числа {num2}");
}



    


