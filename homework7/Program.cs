// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

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
