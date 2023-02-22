/*
int[,] CreateRandom2dArray ()                    // 2D ARRAY
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

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)       // GetLength(0) - прохождение по строкам. 
    {
        for(int j = 0; j < array.GetLength(1); j++)   // GetLength(1) - второе измерение, столбцы

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray();

Show2dArray(MyArray);
*/

// Самостоятельная работа 1. Напишите программу, которая генерирует 2d массив, элементы которого получаем - сумма индексов (i + j)
/*
int[,] CreateRandom2dArray ()                    
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)

        for(int j = 0; j < columns; j++)

            array[i, j] = i + j;

    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)       // GetLength(0) - прохождение по строкам. 
    {
        for(int j = 0; j < array.GetLength(1); j++)   // GetLength(1) - второе измерение, столбцы

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray();

Show2dArray(MyArray);

*/
// Самостоятельная работа 2. Напишите программу, которая генерирует 2d массив, и найти элементы, у которых индексы четные. и возвести эти элементы в квадрат
/*

int[,] CreateRandom2dArray ()                    
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

int[,] Quadrum (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)    // Идем по четным индексам
    {
        for(int j = 0; j < array.GetLength(1); j += 2)
            array[i,  j] *= array[i,  j];
    }
    return array;
}

int[,] MyArray = CreateRandom2dArray();

Show2dArray(MyArray);
int [,] NewMyArray = Quadrum(MyArray);
Show2dArray(NewMyArray);
*/


// Самостоятельная работа 3. Напишите программу, которая генерирует 2d массив и находит сумму элементов, находящихся на главной диагонали (0, 0), (1, 1)
/*
int[,] CreateRandom2dArray ()                    
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();


    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)

        for(int j = 0; j < columns; j++)

            array[i, j] = new Random().Next(minValue, maxValue + 1);

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

int Sum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
    }       
    return  sum;
}


 
int[,] MyArray = CreateRandom2dArray();

Show2dArray(MyArray);
int sum = Sum(MyArray);
Console.WriteLine("The sum of elements of array is " + sum);

*/