// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Метод создает матрицу заполненную случайными числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    Random rnd = new Random();
    int[,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

//Метод печатает матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2}, ");
            else Console.Write($"{matrix[i, j],2}");
        }
        Console.WriteLine("]");
    }
}

// Метод вычисляет среднее арифметическое по столбцам и заносит результат в одномерный массив
double[] AverageColumn(int[,] array)
{
    double[] ar = new double[array.GetLength(1)];
    double count = 0;
    double sum = 0;
    double average = default;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
            count++;
        }
        average = sum / count;
        ar[j] = average;
        count = default;
        sum = default;
    }
    return ar;
}

void PrintArray(double[] ar2) //задаем метод для печати итогового результата в виде массива
{
    Console.Write("Everage of each column -> ");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}");
        else Console.Write($"{ar2[i]}, ");
    }
}

int[,] matrix = CreateMatrixRndInt(5, 7, 1, 99);
PrintMatrix(matrix);
double[] array = AverageColumn(matrix);
PrintArray(array);
Console.WriteLine();
