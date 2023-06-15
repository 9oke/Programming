// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int[] array = new int[8];

int[] array0 = new int[] { 3, 6, 8, 8, 7 };
int[] array01 = new int[11] { 3, 6, 8, 8, 7, 6, 8, 4, 4, 6, 6 };
int[] array1 = { 1, 4, 7, 8 };

var array2 = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
array2[5] = 45;
array2[0] = 4;

for (int i = 0; i < array2.Length; i++)
{
    array2[i] = i * 2;
    Console.Write(array2[i] + " ");
}
