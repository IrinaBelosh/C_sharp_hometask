// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

//Метод перемножает матрицы
int[,] MultiplyMatrix(int[,] mat1, int[,] mat2)
{
    int[,] maltiplyMat = new int[mat1.GetLength(0), mat2.GetLength(1)];
    int sum = default;
    if (mat1.GetLength(1) != mat2.GetLength(0)) Console.WriteLine("Operation is impossible");
    else
    {
        for (int imat1 = 0; imat1 < mat1.GetLength(0); imat1++)
        {
            for (int jmat2 = 0; jmat2 < mat2.GetLength(1); jmat2++)
            {
                sum = default;
                for (int imat2 = 0, jmat1 = 0; jmat1 < mat1.GetLength(1); imat2++, jmat1++)
                {
                    sum = sum + (mat1[imat1, jmat1] * mat2[imat2, jmat2]);
                }
                maltiplyMat[imat1, jmat2] = sum;
            }
        }
    }
    return maltiplyMat;
}

int[,] matrix1 = CreateMatrixRndInt(4, 3, 1, 10);
int[,] matrix2 = CreateMatrixRndInt(3, 2, 1, 10);
Console.WriteLine("first matrix");
PrintMatrix(matrix1);
Console.WriteLine("second matrix");
PrintMatrix(matrix2);
Console.WriteLine("multiplication");
int[,] multMat = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(multMat);
