// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"




void RowOfNumbers(int num)
{
    if (num != 0)
    {
        Console.Write($"{num}");
        RowOfNumbers(num - 1);
    }
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> ");
if (number == 0) Console.Write(0);
else RowOfNumbers(number);

