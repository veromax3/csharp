// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray1()
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
void Show2dArray1 (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CopiedArray(int[,] array)
{
    int [,] copiedArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            copiedArray[i, j] = array[i, j];
    }
    Console.WriteLine();
    return copiedArray;

}

int[,] ReverseOrder(int[,] reverseOrder)  
{
    int revOrder = -1; 
    int temp = 0;
    for (int i = 0; i < reverseOrder.GetLength(0); i++)
    { 
        for (int count = 0; count < reverseOrder.GetLength(1) - 1; count++)
        {    
            for (int j = 0; j < reverseOrder.GetLength(1) - 1; j++)
            {
                if(reverseOrder[i, j] * revOrder > reverseOrder[i, j + 1] * revOrder)
                {
                    temp = reverseOrder[i, j];
                    reverseOrder[i, j] = reverseOrder[i, j + 1];
                    reverseOrder[i, j+ 1] = temp;
                }
            }
        }
    }
    return reverseOrder;

}

int[,] newArray1 = CreateRandom2dArray1();
Show2dArray1(newArray1);

int[,] copiedArray = CopiedArray(newArray1);

int[,] reverseOrderArray = ReverseOrder(copiedArray);
Show2dArray1(reverseOrderArray);

