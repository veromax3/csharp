// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums1(int num)
{
    Console.Write(num + " ");
    if (num > 1) ShowNums1(num - 1);
    else if (num < 1) ShowNums1(num + 1);
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums1(num);
Console.WriteLine();
Console.WriteLine();


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ShowNums2(int num1, int num2)
{
    if (num1 < num2) return num1 + ShowNums2(num1 + 1, num2);
    else if (num1 > num2) return num1 + ShowNums2(num1 - 1, num2);
    return num1;
}

Console.Write("Input the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int showNums2 = ShowNums2(num1, num2);
Console.WriteLine($"The sum of the elements, that lie between {num1} and {num2}, is: {showNums2}");
Console.WriteLine();



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    if(m > 0 && n > 0) return Ackermann(m -1, Ackermann(m, n -1));
    else if(m > 0 && n == 0) return Ackermann(m -1, 1);
    return 1 + n;
}

Console.Write("Input the first number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction = Ackermann(m, n);
Console.Write($"The result of Ackermann function for m = {m} and n = {n} is: {AckermannFunction}");
