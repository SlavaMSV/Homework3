/* Напишите программу, которая принимает 
на вход пятизначное число и проверяет, 
является ли оно палиндромом */

int Getnumber (string message)
{
int result = 0;
Console.WriteLine(message);
while (true)
{
    if (int.TryParse(Console.ReadLine(), out result) && result < 100000 && result>=10000)
    {
    break;
    } 
    else 
    {
    Console.WriteLine("Введите только пятизначное число!!!:");
    } 
}
return (result);
}

string Palindromcheck (int number)
{
    if (number%10 == number/10000 && (number/10)%10 == (number/1000)%10)
    return "является палиндромом";
    else
    return "не является палиндромом";
}
int number = Getnumber("Введите пятизначное число: ");
string palindrom = Palindromcheck(number);
Console.WriteLine ($"Число {number} {palindrom}");



