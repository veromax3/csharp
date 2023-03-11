// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray1()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

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

Console.WriteLine("TASK 54");
int[,] newArray1 = CreateRandom2dArray1();
Show2dArray1(newArray1);

int[,] copiedArray = CopiedArray(newArray1);
int[,] reverseOrderArray = ReverseOrder(copiedArray);
Console.WriteLine("The array with row elements in descending order: ");
Show2dArray1(reverseOrderArray);
Console.WriteLine();


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray2()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray2 (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray2 (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

int[] SumInRows(int[,] array)
{
    
    int[] arraySumInRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        arraySumInRow[i] = sum;
    }
    return arraySumInRow;
}

int RowSWithmallestSum(int[] array)
{
    int minimum = array[0];
    int rowMinSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
            rowMinSum = i;
        }
    }
    return (rowMinSum + 1);
}

Console.WriteLine("TASK 56");
int[,] newArray2 = CreateRandom2dArray2();
Show2dArray2(newArray2);

int[] sumElementsInRows = SumInRows(newArray2);
Console.WriteLine("The sums of elements of rows: ");
ShowArray2(sumElementsInRows);

int RowWithMinSum = RowSWithmallestSum(sumElementsInRows);
Console.WriteLine("The row with smallest sum of elements is: " + RowWithMinSum);
Console.WriteLine();



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray3()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray3 (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] matrixProduct = new int[array1.GetLength(0), array2.GetLength(1)];

    if(array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                matrixProduct[i, j] = 0;

                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    matrixProduct[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }   
    else
    {
        Console.WriteLine("Input error!");
    }

    return matrixProduct;
}

Console.WriteLine("TASK 58");
Console.WriteLine("Set dimensions for the first matrix");
int[,] newArray3 = CreateRandom2dArray3();
Console.WriteLine("Set dimensions for the second matrix");
int[,] newArray4 = CreateRandom2dArray3();

Console.WriteLine("The first matrix is: ");
Show2dArray3(newArray3);

Console.WriteLine("The second matrix is: ");
Show2dArray3(newArray4);

int[,] matrixProduct = MatrixProduct(newArray3, newArray4);
Console.WriteLine("The result of 2 matrices product is: ");
Show2dArray3(matrixProduct);





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] UniqueElements(int x, int y, int z)
{
    int[] array = new int[x * y * z];
    int num = 0;
   
    for (int i = 0; i < (x * y * z); )
    {
        bool uniqueness = true;
        num = new Random().Next(10, 99 + 1);
        for(int j = 0; j < i; j++)

            if (array[j] == num) uniqueness = false;

        if(uniqueness == true)
        {
            array[i] = num;
            i++;
        }
       
       
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
    Console.WriteLine();
}

int[,,] FillByUniqueElements(int[] array, int x, int y, int z)
{
    int count = 0;
    int[,,] fillByUniqueElements = new int[x, y, z];
    while(count < x * y * z)
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            for (int k = 0; k < x; k++)
            {
                fillByUniqueElements[i, j, k] = array[count];
                count++;
            }
        }
    }
    return fillByUniqueElements;
}


void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CheckOut(int x, int y, int z)
{
    if((x * y * z) > 90) Console.WriteLine("Error! An array of this size can't contain two digit elements without repeats!");
    if (x != y || y != z || x != z) Console.WriteLine("Error! Сalculations are possible for a cubic array!");
}

Console.WriteLine("TASK 60");
Console.Write("Input a coordinate x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a coordinate y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a coordinate z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

CheckOut(x,  y,  z);

int[] array = UniqueElements(x,  y,  z);
Console.Write("Sequence of unique two digit numbers: ");
ShowArray(array);

int[,,] fillByUniqueElements = FillByUniqueElements(array, x, y, z);
Console.WriteLine("3D array containing this unique sequence: ");
Console.WriteLine();
Show3DArray(fillByUniqueElements);



