int[,] CreateRandom2dArray (int rows, int columns, int minValue, int maxValue)
{
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

Console.WriteLine("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(MyArray);


