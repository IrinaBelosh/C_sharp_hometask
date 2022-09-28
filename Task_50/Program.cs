// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

//Метод создает массив заполненный случайными числами
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

//Метод печатает массив
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

//Метод ищет элемент по введенным координатам
int FindElement(int[,] array, int iMethod, int jMethod)
{
    int foundElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (iMethod == i && jMethod == j) foundElement = array[i, j];
        }
    }
    return foundElement;
}


int[,] array = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array);

Console.Write("Enter the position of an element (i j) : "); //запрашиваем у пользователя координаты элемента
string[] arr = Console.ReadLine().Split();
int iUser = int.Parse(arr[0]);
int jUser = int.Parse(arr[1]);
if (iUser > array.GetLength(0) || jUser > array.GetLength(1)) //проверяем не выходят ли координаты за рамки массива
{
    Console.WriteLine("element beyound array");
}
else
{
    int result = FindElement(array, iUser, jUser); //ищем элемент
    Console.WriteLine($"the element -> {result}"); //выводим результат
}
