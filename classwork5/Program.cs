// Задача 1. Сгенерировать рандомныый массив из 12 элементов от -9 до 9, включая границы. Найти сумму отрицательных элементов массива
/*


int [] CreateRandomArray(int size, int minValue, int maxValue)   //Метод для генерации рандомного массива
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
} 
void ShowArray(int[] array)                                   // Метод для вывода массива в консоль
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int GetSumOfNegatives (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray); 

int sumOfNegatives = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negatives is " + sumOfNegatives);
*/


// Самостоятельная задача 1. Напишите программу, которая в массиве меняет положительные элементы на отрицательные и наоборот
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] reverseArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
       array[i] *= -1;
    return array;
}


Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray); 

int[] ReverseArray = reverseArray(myArray);

ShowArray(ReverseArray);

*/


// Самостоятельная задача 2. Напишите программу, которая задает массив и проверяет, присутствует ли заданное число в массиве
/*
int [] CreateArray(int size)   
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
} 

void ShowArray(int[] array)                                   
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool check(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
        if  (array[i] == number)
            return true;
    return false;
}


Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number: ");             
int Number = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateArray(length);
ShowArray(myArray); 

bool checkNum = check(myArray, Number);
Console.WriteLine($"The number {Number} is in array: {checkNum}");

*/

// Самостоятельная задача 3. Напишите программу, которая формирует массив из N чисел и определяет количество элементов, значения которых лежат в отрезке от А до В
/*
int [] CreateArray(int size)   
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
} 

void ShowArray(int[] array)                                   
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int check(int[] array, int number1, int number2)
{  int counter = 0; 
   for (int i = 0; i < array.Length; i++)
        if  (array[i] >= number1 && array[i] <= number2)
            counter++;
    return counter;
}

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray); 

Console.Write("Input a boundarie 1: ");             
int boundarie1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a boundarie 2: ");             
int boundarie2 = Convert.ToInt32(Console.ReadLine());

int checkNumBetweenBoundaries = check(myArray, boundarie1, boundarie2);
Console.WriteLine($"Quantity of array elements, which are lying between {boundarie1} and {boundarie2}, is: {checkNumBetweenBoundaries}");
*/
