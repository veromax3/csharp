// задача 1. Напишите программу, которая перевернет одномерный массив
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array; 
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {    
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

/*
void ReverseArray (int[] array)                                           Короткая записать вышеизложенного метода
{
    for (int i = 0, j = array.Length  1; i < j; i++, j--)
    {    
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

*/

/*

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray); 

ReverseArray(myArray);
ShowArray(myArray); 
*/


// Самостоятельная работа 1. Напишите программу, которая принимает на вход 3 числа и 
// проверяет, может ли существовать треугольник со сторонами такой длины
/*
bool Triangle(int sideA, int sideB, int sideC)
{
    if ((sideA < sideB + sideC) && (sideB < sideA +sideC) && (sideC < sideA + sideB))
        return true;
        else return false;
}

Console.WriteLine("Input side A of triagle: ");
int SideA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input side B of triagle: ");
int SideB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input side C of triagle: ");
int SideC = Convert.ToInt32(Console.ReadLine());

bool triagle = Triangle(SideA, SideB, SideC);
Console.WriteLine($"The triagle with sides {SideA}, {SideB} and {SideC} exsists: {triagle}");

*/




// Самостоятельная работа 2. Напишите программу, которая выводит первые N чисел Фибоначчи. Первые два числа это a и b

/*
int[] FibonacciSeq(int firstNum, int secondNum, int size)
{
    int[] NewSeq = new int[size];
    NewSeq[0] = firstNum;
    NewSeq[1] = secondNum;

    for (int i = 2; i < size - 1; i++)
        NewSeq[i] = NewSeq[i - 2] + NewSeq[i - 1];
    return NewSeq;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.WriteLine("Input the length of fibonacci sequence: ");
int lengthSeq = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the first number of fibonacci sequence: ");
int FirstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number of fibonacci sequence: ");
int SecondNum  = Convert.ToInt32(Console.ReadLine());

int[] FibonacciSequence = FibonacciSeq(FirstNum, SecondNum, lengthSeq);
ShowArray(FibonacciSequence);

*/



// Самостоятельная работа 3. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array; 
}

int[] CreateCopyArray(int[] array)
{
    int[]copiedArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        copiedArray[i] = array[i];
    return copiedArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] *= -1;
}

Console.Write("Input a length of new array: ");             
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpit a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inpit a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray1 = CreateRandomArray(length, min, max);

int[] myArray2 = CreateCopyArray(myArray1);

ReverseArray(myArray1);

ShowArray(myArray1);
ShowArray(myArray2);

*/