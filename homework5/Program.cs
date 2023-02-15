// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size)   
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
} 

void ShowArray(int[] array)                                   
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
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray); 

int quantityEvenNum = QuantityEvenNum(myArray);
Console.WriteLine("Quantity of even numbers in array is " + quantityEvenNum);

*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
} 

void ShowArray(int[] array)                                   
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
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray); 

int getSumNumOddIndex = GetSumNumOddIndex(myArray);
Console.WriteLine("Sum of numbers with odd index is " + getSumNumOddIndex);
