// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter two numbers: ");
string[] array = Console.ReadLine(). Split();
int m = int.Parse(array[0]);
int n = int.Parse(array[1]);
int result = SumBetweenNumbers(m,n);
Console.WriteLine(result);

int SumBetweenNumbers(int m1, int n1)
{
    int sum = n1;
    if (m1<n1) sum += SumBetweenNumbers(m1, n1-1);
    if (m1>n1) sum += SumBetweenNumbers(m1, n1+1);
    return sum;
}