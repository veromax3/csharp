// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
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

int[,] newArray1 = CreateRandom2dArray1();
Show2dArray1(newArray1);

int[,] copiedArray = CopiedArray(newArray1);
int[,] reverseOrderArray = ReverseOrder(copiedArray);
Console.WriteLine("The array with row elements in descending order: ");
Show2dArray1(reverseOrderArray);
Console.WriteLine();
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray2()
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

int[,] newArray2 = CreateRandom2dArray2();
Console.WriteLine("The sums of elements of rows ");
Show2dArray2(newArray2);

int[] sumElementsInRows = SumInRows(newArray2);
ShowArray2(sumElementsInRows);

int RowWithMinSum = RowSWithmallestSum(sumElementsInRows);
Console.WriteLine("The row with smallest sum of elements is: " + RowWithMinSum);
Console.WriteLine();

*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray3()
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

int[,] newArray3 = CreateRandom2dArray3();
int[,] newArray4 = CreateRandom2dArray3();

Console.WriteLine("The first matrix is: ");
Show2dArray3(newArray3);

Console.WriteLine("The second matrix is: ");
Show2dArray3(newArray4);

int[,] matrixProduct = MatrixProduct(newArray3, newArray4);
Console.WriteLine("The result of 2 matrices product is: ");
Show2dArray3(matrixProduct);

*/



// 

/*
int [,,] CreateRandom3DArray(int[] array, int x, int y, int z)
{
    
    int[,,] uniqueArray3D = new int[x, y, z];

    while(int count < (x * y * z))
    {
        for(int i = 0; i < x; i++)
        {
            for(int j = 0; j < y; j++)
            {
                for(int k = 0; k < z; k++)
                {
                    uniqueArray3D[i, j, k] = array[count];
                    count++;
                    
                }
            }
        }
    }
                
}
   
 */              
    


int[] CreateUniqueRandomArray (int x, int y, int z)
{
    int[] array = new int[x * y * z];
    bool uniqueNum = true;
    for (int i = 0; i < (x * y * z); )
    {
        int newNum = new Random().Next(10, 99 + 1);
        for (int j = 0; j < i; j++ )
        {
            if (array[j] == newNum)
            {
                uniqueNum = false;
            }
        }   
        if(uniqueNum == true)
        {
            array[i] = newNum;
            i++;
        }
        
    }
    return array;
}


void Showrray1(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
/*
void Show3DArray1(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
           
            Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        Console.WriteLine();
        }
    }
    Console.WriteLine();
}
*/
Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] createUniqueRandomArray = CreateUniqueRandomArray(x, y, z);

Showrray1(createUniqueRandomArray);

/*
int[,,] new3DArray = CreateRandom3DArray();

Show3DArray1(new3DArray);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

/*
int[,] CreateRandom2dArray4()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input step size to increase value value: ");
    int step = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows,columns];
    int num = minValue; // переменная, в которой находится число массива
    
    while (num <= (columns * rows) * step)
    {
        for (int i = 0; i < rows; )
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = num;
                num = num + step; 
            }
        }

        for (int j = columns - 1; j > columns / 2 ;)
        {
            for (int i = 1; i < rows; i++)
            {
                array[i, j] = num;
                num = num + step;
            }
        }
        
        for (int i = rows - 1; i > rows / 2 ; )
        {
            for (int j = columns - 2; j >= 0; )
            {
                array[i, j] = num;
                num = num + step;
            }
        }

        for (int j = 0; ; j++)
        {
            for (int i = rows - 2; i >= 0; )
            {
                array[i, j] = num;
                num = num + step;
            }
        }

    }
    
return array;
}



void Show2dArray4 (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] spiralArray = CreateRandom2dArray4();
Show2dArray4(spiralArray);



*/

