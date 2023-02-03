// Задача 1. Напишите программу, которая на вход принимает трехзначное число и удаляет вторую цифру этого числа
/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;
    int result = sot * 10 + ed;
    return result;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int NewNum = CutNumber(num);
Console.WriteLine($"New version of {num} is {NewNum}");

******************************************************************************

int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;
    int result = sot * 10 + ed;
    return result;
}

int num = new Random().Next(100, 1000);                // диапозон метода new Random().Next() работает от _минимального_ до _максимального -1_ значений
int NewNum = CutNumber(num);
Console.WriteLine($"New version of {num} is {NewNum}");

*/

//*******************************************************************************

// Задача 2. Самостоятельная. Напишите программу, которая на входе принимает случайные числа из отрезка от 10 до 99 включительно и 
// показывает наибольшую цифру этого числа
/*
int CutNumber(int num)
{   
    Console.WriteLine(num);
    int TheFirstSign = num / 10;
    int TheSecondSign = num % 10;
    
    if(TheFirstSign > TheSecondSign)
    return TheFirstSign;

    if(TheFirstSign < TheSecondSign)
    return TheSecondSign;
    
    else
    {
        return TheFirstSign;
    }
}

int number = new Random().Next(10, 100);
int NewNumber = CutNumber(number);
Console.WriteLine(NewNumber);

*/

//******************************************************************************

// Задача 3. Самостоятельная. Напишите программу, которая на входе принимает 2 числа и выводит, является ли второе число кратным первому
 /*
bool multiplicity(int arg1, int arg2)
{
    bool result1 = true;
    bool result2 = false;
    int remainder = arg2 % arg1;
        if(remainder == 0)
            return result1;
        else
            return result2;
}

Console.WriteLine("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
   

bool multiplicityNumber = multiplicity(num1, num2);
Console.WriteLine(multiplicityNumber);

*/

// Задачаю. Самостоятельная. Напишите программу, которая на входе 2 числа и выводит, является ли одно число квадратом второго













