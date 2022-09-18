// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a degree: ");
int degree = Convert.ToInt32(Console.ReadLine());

int Degree (int num, int deg)
{
    int circle = 1;
    for (int i = 0; i < deg; i++)
    {
        circle = circle*num;
    }
    return circle;
}
int result = Degree(number, degree);
Console.WriteLine($"{number} -> {result}");
