// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int QuantityEvenNum (int [] array)
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
