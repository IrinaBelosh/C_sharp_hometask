// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int Final(int a) //Функция вычисляет последнюю цифру трехзначного числа.
{
    return a % 10;
}

int ToThree(int b) // Функция, сводящая любое число к трехзначному
{
    while (b / 10 > 99)
    {
        b = b / 10;
    }
    return b % 10;
}

if (num > 99 && num < 1000)
{
    int final = Final(num);
    Console.WriteLine(final);
}
else
{
    if (num < 100)
    {
        Console.WriteLine("There is no third digit");
    }
}
if (num > 999)
{
    int tothree = ToThree(num);
    Console.WriteLine(tothree);
}