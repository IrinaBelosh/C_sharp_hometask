// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 > num1) max = num2;
if (num3 > num2) max = num3;
Console.WriteLine($"The maximum number is {max}.");