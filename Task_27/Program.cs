// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int division = 0;
    for (int i = 0; num > 0; i++)
    {
        division = division + num % 10;
        num = num / 10;
    }
    return division;
}
int result = SumDigits(number);
Console.WriteLine($"{number} -> {result}");
