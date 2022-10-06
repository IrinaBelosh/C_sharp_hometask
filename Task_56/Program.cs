// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

//Метод, который ищет искомую строку
void FindMinimumSumRow(int[,] mat)
{
    int count = 0;
    int sumMin = 0;
    int sum = 0;
    int line = 0;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                sumMin = sumMin + mat[i, j];
            }
        }
        else
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                sum = sum + mat[i, j];
            }
            if (sum < sumMin)
            {
                sumMin = sum;
                line = count+1;
            }
        }
        count++;
    }
    Console.WriteLine($"Minimum summ is in line {line}");
}

int[,] myMatrix = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(myMatrix);
FindMinimumSumRow(myMatrix);