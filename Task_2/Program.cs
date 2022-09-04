// // Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.Clear();
Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"{num1} - min, {num2} - max");
}
else
{
    Console.WriteLine($"{num1} - max, {num2} - min");
}