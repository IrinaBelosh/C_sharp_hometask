// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = new int[8];//задаем массив

void FillArray (int[] ar1)
{
    Random rnd = new Random(); //лучше создавать отдельную переменную для рандомных чисел вне цикла иначе при большой скорости обработки на выходе все числа будут одинаковыми
    for (int i = 0; i < ar1.Length; i++)
    {
        ar1[i] = rnd.Next(0,100);
    }
}

void PrintArrayBrackets(int[] ar2)
{
    for (int i = 0; i < ar2.Length; i++)
    {
        if(i==0) Console.Write("[");
        if (i==ar2.Length-1) Console.Write($"{ar2[i]}]");
        else Console.Write($"{ar2[i]}, ");
    }
}

void PrintArrayNoBrackets(int[] ar3)
{
    for (int i = 0; i < ar3.Length; i++)
    {
        if (i==ar3.Length-1) Console.Write($"{ar3[i]} -> ");
        else Console.Write($"{ar3[i]}, ");
    }
}

FillArray(array);
PrintArrayNoBrackets(array);
PrintArrayBrackets(array);

