// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Turn(int x)
{
    int first = x / 10000;
    int second = x / 1000 % 10;
    int fifth = x % 10;
    int forth = x % 100 / 10;
    if (first == fifth && second == forth) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}

if (num < 100000 && num > 9999)
{
    Turn(num);
}
else
{
    Console.WriteLine("Incorrect number");
}
    
