// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateAndFillArrayRandInt(int size, int min, int max) //задаем метод создания массива из случайных чисел
{

    int[] array = new int[size]; //задаем новый массив и его размер
    Random rnd = new Random(); //вводим случайную переменную отдельно
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); //задаем диапазон
    }
    return array;
}

void PrintArray(int[] ar2) //задаем метод для печати массива, красиво, со скобочками
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

int OddPositionSum(int[] ar3)
{
    int oddNumberSum = 0;
    for (int i = 0; i < ar3.Length; i++)
    {
        if (i % 2 == 1) oddNumberSum = oddNumberSum + ar3[i];
    }
    return oddNumberSum;
}

Console.Clear();
int[] randomArray = CreateAndFillArrayRandInt(5, 1, 100);
PrintArray(randomArray);
Console.WriteLine();
int sum = OddPositionSum(randomArray);
Console.Write($" -> {sum}");
Console.WriteLine();
