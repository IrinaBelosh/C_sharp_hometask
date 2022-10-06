// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Метод создает спиральную матрицу
int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] matr = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num < rows * columns)
    {
        while (j < columns - 1 && matr[i, j + 1] == 0) //i=1, j=1
        {
            matr[i, j] = num;
            num++;
            j++;
        }
        while (i < rows - 1 && matr[i + 1, j] == 0) //j=2, i=1
        {
            matr[i, j] = num;
            num++;
            i++;
        }
        while (j > 0 && matr[i, j - 1] == 0) //j=3, i=3
        {
            matr[i, j] = num;
            num++;
            j--;
        }
        while (i > 0 && matr[i - 1, j] == 0) // j=1, i=3
        {
            matr[i, j] = num;
            num++;
            i--;
        }
        matr[i, j] = num; //i=1, j=1
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

int[,] myMatrix = CreateSpiralMatrix(4, 4);
PrintMatrix(myMatrix);