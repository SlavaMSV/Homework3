/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int Getcoord (string message)
{
int result = 0;
Console.WriteLine(message);
while (true)
{
    if (int.TryParse(Console.ReadLine(), out result))
    {
    break;
    } 
    else 
    {
    Console.WriteLine("Введите только целое число:");
    } 
}
return (result);
}
double Getdist(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return result;
}
int x1 = Getcoord("Введите значение x1: ");
int y1 = Getcoord("Введите значение y1: ");
int z1 = Getcoord("Введите значение z1: ");
int x2 = Getcoord("Введите значение x2: ");
int y2 = Getcoord("Введите значение y2: ");
int z2 = Getcoord("Введите значение z2: ");

double distance = Getdist(x1, x2, y1, y2, z1, z2);
Console.WriteLine ($"Расстояние между точками в 3d пространстве равно: {distance:.##}");