

//////////////////////////////////////Рекурсия

// Задача 1. Напишиет программу, которая выведет все натуральные числа от 1 до N(получаем от пользователя, как аргумент)
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/

// Задача 2. Напишиет программу, которая принимает на вход некоторое число и возвращает сумму его цифр
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

int result = SumOfDigits(1234);
Console.WriteLine(result);
*/
/* 
f(1234) -> f(123) + 4   Погружение в рекурсию
f(123) -> f(12) + 3
f(12) -> f(1) + 2
f(1) -> f(0) + 1
f(0) -> 0
f(1) -> 0 + 1 = 1       Выход из рекурсии
f(12) -> 1 + 2 = 3
f(123) -> 3 + 3 = 6
f(1234) -> 6 + 4 = 10
*/

// Самостоятельная задача 1. Задайте значения M и N и напишите программу, которая выведет все натуральные числа в промежутке от M до N

/*
void ShowNums2(int num1, int num2)
{
    
    if (num1 < num2) 
    {
        Console.Write(num1 + " ");
        ShowNums2(num1 + 1, num2);
    }
    
    else if (num1>num2) 
    {
        Console.Write(num1 + " ");
        ShowNums2(num1 - 1, num2);
    }
    
    else if (num1 == num2) 
    {
        Console.Write(num1);
    }
}

Console.Write("Input number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Input number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

ShowNums2(num1, num2);
*/



// Самостоятельная задача 2. Напишите задачу, которая принимает на вход 2 числа, a и b, и возводит число а в целую степень b 

double CustomPow(double a, int b)
{
    if (b > 0) return a * CustomPow(a, b - 1);
    if (b < 0) return 1/a * CustomPow(a, b + 1);

    return 1;
}

Console.WriteLine(CustomPow(2, 3));
Console.WriteLine(CustomPow(2, -3));
