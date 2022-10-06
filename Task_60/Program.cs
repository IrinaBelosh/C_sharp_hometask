// Задача 60. Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

//Метод создает матрицу заполненную случайными числами
int[,,] CreateThreeDimentionMatrixRndInt(int rows, int columns, int depth)
{
    int firstDigit = 10;
    int[,,] matr = new int[rows, columns, depth];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (firstDigit > 98) break;
                else matr[i, j, k] = firstDigit += 1;
            }
        }
    }
    return matr;
}

//Метод печатает матрицу

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],3} ({i},{j},{k}), ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] myMatrix = CreateThreeDimentionMatrixRndInt(3, 3, 3);
PrintMatrix(myMatrix);
Console.WriteLine();