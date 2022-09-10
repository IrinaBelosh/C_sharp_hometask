// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int Div(int a)
{
    return (a % 100)/10;
}
int div = Div(number);
Console.WriteLine(div);
