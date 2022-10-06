// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

//Метод сортирующий строки массива
void SortRows(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            int jmax = j;
            int imax = i;
            for (int k = j + 1; k < mat.GetLength(1); k++)
            {
                if (mat[i,k] > mat[imax, jmax]) jmax = k;
            }
            int temp = mat[i,j];
            mat[i,j] = mat[imax,jmax];
            mat[imax,jmax] = temp;
        }
    }
}

int[,] myMatrix = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(myMatrix);
Console.WriteLine();
SortRows(myMatrix);
PrintMatrix(myMatrix);

