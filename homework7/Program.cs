// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*
double[,] CreateRandom2dArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    int  maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];

    for(int m = 0; m < rows; m++)
        for(int n = 0; n < columns; n++)
            array[m, n] = new Random().Next(minValue, maxValue) + Math.Round((new Random().NextDouble()), 2);
    return array;
}
void Show2dArray (double[,] array)
{
    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
            Console.Write(array[m, n] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MyArray = CreateRandom2dArray();
Show2dArray(MyArray);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray ()
{
    int rows = new Random().Next(0, 20 + 1);
    int columns = new Random().Next(0, 20 + 1);
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(0, 500 + 1);
    return array;
}
void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void findNumber(int[,] array)
{
    Console.WriteLine("Input a row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if ((row <= array.GetLength(0)) && column <= array.GetLength(1))
        Console.WriteLine($"The number with index[{row}, {column}] is {array[row, column]}");
    else
    {
        Console.WriteLine($"The number with index[{row},{column}] is not found");
    }

    Console.WriteLine();
    
}

int[,] MyArray = CreateRandom2dArray();
findNumber(MyArray);
Show2dArray(MyArray);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2DArray ()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2DArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 1) + " ");
    Console.WriteLine();
}


double[] Average(int[,] array)
{
    
    double[] arrayMean = new double[array.GetLength(1)];

    for(int ii = 0, j = 0; j < array.GetLength(1) && ii < array.GetLength(1); ii++, j++)
    {
        double mean = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            mean = (array[i, j] + mean);
            
        }
        arrayMean[ii] = (mean / array.GetLength(0));
    } 
    return arrayMean;
}


int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
double[] average = Average(myArray);
ShowArray(average);
