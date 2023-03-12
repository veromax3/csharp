// Необходимо написать программу, которая из имеющего массива строк, формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно вводить с клавиатуры либо задать на старте выполнения алгоритма.

string[] CreateFillArray(int length)
{
    string[] array = new string[length];
    for(int i = 0; i < length; i++)
    {
        Console.Write("Input the word, number or symbols: ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine();
    return array;
}

void ShowArray(string[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
    Console.WriteLine();
}

string[] CheckOutLength(string[] array)
{
    int size = 0;
    Console.WriteLine("The array, containing word, number or symbols, whose length is less than 3 or equal to 3: ");
    for(int i = 0; i < array.Length; i++)
    {
        int stringLength = array[i].Length;
        if(stringLength <= 3) size++;
    }

    string[] newArray = new string[size];
    for(int i = 0, j = 0; i < array.Length && j < size; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine("Input the length of array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string[] newArray = CreateFillArray(arrayLength);
Console.WriteLine("The array: ");
ShowArray(newArray);

string[] threeSymbolsArray = CheckOutLength(newArray);
ShowArray(threeSymbolsArray);