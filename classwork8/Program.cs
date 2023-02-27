// Задача 1. Напишите программу, которая задает массив и меняет местами первую и последнюю строки массива
/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
    row2 >= 0 && row2 < array.GetLength(0) &&
    row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.WriteLine("Input a number of the first row for changing: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of the second row for changing: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2dArray(newArray);
*/
// Самостоятельная задача 1. Напишите программу, которая задает двумерный массив и меняет строки на столбцы
/*
int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
    Console.WriteLine();

    }
    Console.WriteLine();
}

void SwapRowsAndColumns(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[j, i] + " ");
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Error!");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

SwapRowsAndColumns(newArray);
*/

// Самостоятельная задача 1. Напишите программу, которая задает двумерный массив и 
//удаляет строку и столбец, на пересечении которых находится наименьший элемент

int[,] CreateRandom2dArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] MinElement(int[,] array)
{
    int minI = 0;
    int minJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    
    int[] arrayMinEl = new int[2];
    arrayMinEl[0] = minI;
    arrayMinEl[1] = minJ;
    return arrayMinEl;
}


int[,] ArrayWithoutMin(int [,] array, int[] array2)
{
    int[,] arrayWithoutMin = new int[array.GetLength(0) - 1, array.GetLength(1) - 1 ];
    for (int i = 0, x = 0; i < array.GetLength(0); i++)
    { 
        if(i != array2[0])
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++)
            {
                if(j != array2[1])
                {
                    arrayWithoutMin[x, y] = array[i, j];
                    y++;
                }
                
            }
            x++;
        }
    }
    Console.WriteLine();
    return arrayWithoutMin;
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[] min = MinElement(newArray);
int[,] newArray2 = ArrayWithoutMin(newArray, min);
Show2dArray(newArray2);