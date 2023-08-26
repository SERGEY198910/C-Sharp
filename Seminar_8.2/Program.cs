int[,] CreateArray2D(int firstLength, int secondLength)
{
    Random rnd = new Random();
    int[,] array = new int[firstLength,secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
     for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} " );
        }   
        Console.WriteLine();
    }
}
string Input(string text)
{
    System.Console.Write($"{text} ");
    return Console.ReadLine();
}
void ArrangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}
int[,] MultiplicationArray2D(int[,] fArray, int[,] sArray)
{
    int[,] resultArray = new int[fArray.GetLength(0),sArray.GetLength(1)] ;
    if (fArray.GetLength(0) != sArray.GetLength(1))
    {
    Console.WriteLine(" Нельзя перемножить ");
    return resultArray;
    }
    for (int i = 0; i < fArray.GetLength(0); i++)
    {
    for (int j = 0; j < sArray.GetLength(1); j++)
    {
        for (int k = 0; k < sArray.GetLength(0); k++)
        {
            resultArray[i, j] += fArray[i, k] * sArray[k, j];
        }
    }
    }
    return resultArray;
}void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
void PrintArray4D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
void zadacha54()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    array = CreateArray2D(m,n);
    PrintArray(array);
    Console.WriteLine();
    ArrangeRows(array);
    PrintArray(array);
}
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
void zadacha56()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    array = CreateArray2D(m,n);
    PrintArray(array);
    NumberRowMinSumElements(array);
}
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void zadacha58()
{
    int m = Convert.ToInt32(Input("Введите число m: "));
    int n = Convert.ToInt32(Input("Введите число n: "));
    int[,] array = new int[m,n];
    int[,] fisrtArray = new int[m,n];
    int[,] secondArray = new int[m,n];
    fisrtArray = CreateArray2D(m,n);
    PrintArray(fisrtArray);
    Console.WriteLine();
    secondArray = CreateArray2D(m,n);
    PrintArray(secondArray);
    Console.WriteLine();
    array = MultiplicationArray2D(fisrtArray,secondArray);
    PrintArray(array);
    Console.WriteLine();
}
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
void zadacha60()
{
    int[,,] array3D = new int[2, 2, 2];
    FillArray(array3D);
    PrintIndex(array3D);

}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4
void zadacha62()
{
    int len = 4;
    int[,] array = new int[len, len];
    FillArraySpiral(array, len);
    PrintArray4D(array);
}
zadacha62();
zadacha60();
zadacha58();
zadacha56();
zadacha54();


