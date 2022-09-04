// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Enter the number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = num1 % 2;
if (num1 == 0)
{
    Console.WriteLine("NO");
}
else
{
    if (a == 0)
    {
       Console.WriteLine("YES"); 
    }
    else
    {
        Console.WriteLine("NO");
    }
}