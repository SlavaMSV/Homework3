/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Getnumber (string message)
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
void Getcube (int n)
{
    for(int i=1; i <= n; i++)
    {
        Console.Write($"{i*i*i} ");
    }   
}

int n = Math.Abs(Getnumber("Введите целое число: "));
Getcube (n);
