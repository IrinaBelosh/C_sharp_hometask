// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Semaine(int a) // Функция проверяющая является ли число номером дня недели
{
    return (a > 0 && a < 8);
}
bool semain = Semaine(num);
if (semain)
{
    if (num > 0 && num < 6)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}
else
{
    Console.WriteLine("There is no such day");
}