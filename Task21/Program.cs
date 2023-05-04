// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A");
Console.Write("X: ");
int numAx = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int numAy = int.Parse(Console.ReadLine());
Console.Write("Z: ");
int numAz = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("X: ");
int numBx = int.Parse(Console.ReadLine());
Console.Write("Y: ");
int numBy = int.Parse(Console.ReadLine());
Console.Write("Z: ");
int numBz = int.Parse(Console.ReadLine());

double distance = Distance(numAx, numAy, numAz, numBx, numBy, numBz);
double result = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");

double Distance (int numAx, int numAy, int numAz, int numBx, int numBy, int numBz)
{
    double distance = Math.Sqrt(Math.Pow(numBx - numAx, 2) + Math.Pow(numBy - numAy, 2) + Math.Pow(numBz - numAz, 2));
    return distance;
}
