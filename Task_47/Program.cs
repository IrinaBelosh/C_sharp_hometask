// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] CreateMatrixRndDouble(int rows, int columns)
{
    Random rnd = new Random();
    double [,] matr = new double [rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((rnd.NextDouble()*10), 1, MidpointRounding.ToZero);
        }
    }
    return matr;
}

void PrintMatrix(double [,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j<matrix.GetLength(1)-1) Console.Write($"{matrix[i,j], 8} ");
            else Console.Write($"{matrix[i,j],8}   ");
        }
        Console.WriteLine("]");
    }
}

double[,] matrix = CreateMatrixRndDouble(4,5);
PrintMatrix(matrix);

//Вопрос по задаче: Как задать случайную переменную double меньше нуля?