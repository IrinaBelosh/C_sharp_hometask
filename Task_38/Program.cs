// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateAndFillArrayRandInt(int size, int min, int max) //задаем метод создания массива из случайных вещественных чисел
{
    double[] array = new double[size]; //задаем новый массив и его размер
    Random rnd = new Random(); //вводим случайную переменную отдельно
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 100), 1, MidpointRounding.ToZero); //округляем до 1 знака после запятой
    }
    return array;
}

void PrintArray(double[] ar2) //задаем метод для печати массива, красиво, со скобочками
{
    Console.Write("[");
    for (int i = 0; i < ar2.Length; i++)
    {
        if (i == ar2.Length - 1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}


double MinMax(double[] ar3) //вводим метод, который ищет макс и мин и вычисляет из разницу, с учетом их возиожного равенства
{
    double min=ar3[0];
    double max=ar3[1];
    for (int i = 0; i < ar3.Length-1; i++)
    {
        if (ar3[i]!= ar3[i+1])
        {
            if (ar3[i] < min) min = ar3[i];
            if (ar3[i] > max) max = ar3[i];
        }
        else i++;
    }
    return Math.Round((max-min), 1, MidpointRounding.ToZero); //округляем результат до 1 знака от запятой
}

Console.Clear(); 
double[] randomArray = CreateAndFillArrayRandInt(5,0,1); //создаем и заполняем массив
PrintArray(randomArray); //печатаем массив
double result = MinMax(randomArray); //кладем результат работы метода вычисления минмакс в переменную
Console.Write($" -> {result}"); //печатаем его результат
Console.WriteLine();