// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Enter numbers: ");
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int CountPositiveNumbers(int[] ar1)
{
    int count = 0;
    for (int i = 0; i < ar1.Length; i++)
    {
        if (ar1[i] > 0) count += 1;
    }
    return count;
}

int result = CountPositiveNumbers(arr);
Console.WriteLine($" -> {result}");
