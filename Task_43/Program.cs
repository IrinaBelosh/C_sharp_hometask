// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter angle factors: "); //если число переменных известно
string[] arr1 = Console.ReadLine().Split();

double k1 = double.Parse(arr1[0]);
double k2 = double.Parse(arr1[1]);

Console.Write("Enter number factors: ");
string[] arr2 = Console.ReadLine().Split();

double b1 = double.Parse(arr2[0]);
double b2 = double.Parse(arr2[1]);

Console.WriteLine($"Line 1:  y = {k1}x + {b1}");
Console.WriteLine($"Line 2:  y = {k2}x + {b2}");

void AbscisOrdinate(double k1, double k2, double b1, double b2)
{
    if (k1 != k2)
    {
        double x = Math.Round(((b2 - b1) / (k1 - k2)), 2, MidpointRounding.ToZero);
        double y = Math.Round((k1 * x + b1), 2, MidpointRounding.ToZero);
        Console.WriteLine($"The lines cross in ({x} , {y})");
    }
    else
    {
        Console.WriteLine("The lines do not cross");
    }
}

AbscisOrdinate (k1,k2,b1,b2);



