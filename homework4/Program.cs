// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int RaiseToPower(int A, int B)
{
    int result = 1;
    int power = 0;


    if (B != 0)
    {
        while (power < B)
        {
            result = result * A;
            power++;
        }
         return result;
    }    
   

    else
    {
        result = 1;
        return result;
    }
}


Console.WriteLine("Input a power: ");
int numB = Convert.ToInt32(Console.ReadLine());

int raise = RaiseToPower(numA, numB);
Console.WriteLine($"The result of raising number {numA} to the power {numB} is: {raise}");





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму ци846515фр в числе.

int Sum(int Number)
{
    int sum = 0;
    while (Number > 0)
    {
        sum  = sum + Number % 10;
        Number = Number / 10;
    }
    return sum; 
}

Console.WriteLine("Input a number: ");
int Number = Convert.ToInt32(Console.ReadLine());

int SumNumElements = Sum (Number);
Console.WriteLine($"Sum of elements of number {Number} is: {SumNumElements}");






// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран. Массив не рандомный, элементы задаются пользователем

int [] CreateArray(int size)   
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input the {i + 1} element of array: ");
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

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray); 