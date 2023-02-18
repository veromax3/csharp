// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray1(int size)   
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
} 

void ShowArray1(int[] array)                                   
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int QuantityEvenNum (int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if ((array[i] % 2) == 0)
            counter++;
    return counter;
}

Console.Write("Input a length of new array: ");             
int length1 = Convert.ToInt32(Console.ReadLine());

int[] myArray1 = CreateRandomArray1(length1);
ShowArray1(myArray1); 

int quantityEvenNum = QuantityEvenNum(myArray1);
Console.WriteLine("Quantity of even numbers in array is: " + quantityEvenNum);

Console.WriteLine(); // Чтобы отделить задачи друг от друга в терминале





// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray2(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
} 

void ShowArray2(int[] array)                                   
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetSumNumOddIndex (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if ((i % 2) != 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a length of new array: ");             
int length2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray2 = CreateRandomArray2(length2, min1, max1);
ShowArray2(myArray2); 

int getSumNumOddIndex = GetSumNumOddIndex(myArray2);
Console.WriteLine("Sum of numbers with odd index is: " + getSumNumOddIndex);

Console.WriteLine();





// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray3(int size, int minValue, int maxValue)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)  
        array[i] = new Random().Next(minValue, maxValue) + Math.Round((new Random().NextDouble()), 2);
    return array;
} 

void ShowArray3(double[] array)                                   
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double maximum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > maximum)
            maximum = array[i];
    return maximum;
}

double FindMin(double[] array)
{
    double minimum = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < minimum)
            minimum = array[i];
    return minimum;
}

double DiffMaxMin(double maximum, double minimum)
{
    double diff = maximum - minimum;
    return diff;
}

Console.Write("Input a length of new array: ");             
int length3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max2 = Convert.ToInt32(Console.ReadLine());

double[] myArray3 = CreateRandomArray3(length3, min2, max2);
ShowArray3(myArray3); 

double findMax = FindMax (myArray3);
Console.WriteLine("Maximum in array is: " + findMax);

double findMin = FindMin (myArray3);
Console.WriteLine("Minimum in array is: " + findMin);

double diffMaxMin = DiffMaxMin (findMax, findMin);
Console.WriteLine($"Difference between maximum ({findMax}) and minimum ({findMin}) of array is: {Math.Round(diffMaxMin, 2)}");