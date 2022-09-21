// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateAndFillArrayRandInt(int size, int min, int max)//задаем метод, который создает и заполняет массив используя на вводе размер массива и его диапазон
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

int EvenSum(int[] ar3) 
{
    int plusevennumber = 0;
    for (int i = 0; i < ar3.Length; i++)
    {
        if (ar3[i] % 2 == 0) plusevennumber++;
    }
    return plusevennumber;
}

Console.Clear();
int[] randomArray = CreateAndFillArrayRandInt(5, 1, 100);
PrintArray(randomArray);
Console.WriteLine();
int sum = EvenSum(randomArray);
Console.Write($" -> {sum}");
Console.WriteLine();
