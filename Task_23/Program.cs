// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Вариант 1 в столбик
Console.Clear();
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    for (int count = 1; count <= n; count++) //то же, но покороче, без промежуточной переменной
    {
        Console.WriteLine($"{count}  {count * count * count,5}"); //Число 3 после запятой, проставит пробелы как на трехзначное число
    }
}
else
{
    Console.WriteLine("Enter a number bigger than 0");
}


//Вариант 2 в линеечку
Console.Clear();
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Console.Write($"{n}  ->  ");
    for (int count = 1; count <= n; count++)
    {
        Console.Write($"{count * count * count}, ");
    }
}
else
{
    Console.WriteLine("Enter a number bigger than 0");
}
Console.WriteLine();
