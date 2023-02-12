/*
int GetSum(int num)
{
    int sum = 0;

    for (int current = 1; current <= num; current ++) // (int current = 1) объявление один раз переменной. (current <= num) - проверка перед каждой итерацией. (current ++) - действие после каждой итерации в самом конце
         sum += current;
    return sum;
}    

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = GetSum(a);
Console.WriteLine($"Sum of elements form 1 to {a} is {result}");

*/




/*        ЦИКЛ DO WHILE

int a;

do
{
    Console.WriteLine("Input a positive number: ");
    a = Convert.ToInt32(Console.ReadLine());    
} 
while (a <= 0);

*/ 

// Самостоятельная работа 1. Написать программу, которая выдает количество цифр в числе
/*

int CountNum(int num)
{
    int quantity = 0;
    while (num != 0)
    {
        num = num /10;
        quantity++;
    } 
    return quantity;
}

Console.WriteLine("Input a number: ");
int Num = Convert.ToInt32(Console.ReadLine());
int Quantity = CountNum(Num);
Console.WriteLine($"Quantity number in {Num} is: {Quantity}");

*/



// Самостоятельная работа 2. Написать программу, которая принимает на вход число N и находит произведение чисел от 1 до N.

/*

int Factorial(int N)
{
    int factorial = 1;
    for(int factor = 1; factor <= N; factor++)
        factorial *= factor;    //factorial = factorial * (factor + 1)
    return factorial;

    //while (N > 0)           Вариант с while
    // {
    //     factorial *= N;
    //     N --;
    //}
    //return factorial;


}

Console.WriteLine("Input a number: ");
int SomeNum = Convert.ToInt32(Console.ReadLine());
int Result = Factorial(SomeNum);
Console.WriteLine($"Factorial of {SomeNum} is {Result}");

*/







// МАССИВЫ


///////////////////////////////////////////////////////
/*

int [] CreateRandomArray(int size, int minValue, int maxValue)   //Метод для генерации рандомного массива
{
    int[] array = new int[size];

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

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray); 

*/









