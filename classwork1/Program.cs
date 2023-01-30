/* int number = 5; целочисленные переменные
double number2 = 5,46; вещественные переменные, содержащие целую и дробную части
string words = "Hello!"; строка
char letter = "n"; символ
bool check = true; логические переменные, принимающие значения либо true, либо false


// Функционал Console.WriteLine()

int number1 = 5;
int number2 = 8;

Console.WriteLine("My number are " + number1 + " and " + number2 + " and it's good"); // Конкатенацию (сложение строк)
Console.WriteLine($"My number are {number1} and {number2} and it's good"); // использование спецсимвола "$"

// Функционал Console.ReadLine()

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine()); // конвертируем с помощью команды Convert.ToInt32 результат из команды Console.ReadLine()(то есть строку) в тип переменной int. В зависимости от того, в какой тип переменной необходима конвертация, используем Conver.To<тип переменной>
Console.WriteLine("Your number is: " + num);

*/

// Задача 1. Напишите программу, которая принимает на вход два числа и проверяет, является ли первое число квадратов второго числа

/*

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.Write("Yes");   
}
else
{
    Console.Write("No");
}

*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все числа в промежутке от -N до N.


Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = -n;
while (current <= n)
{
    Console.Write(current + " ");
    current++; //current += 1  либо полная форма current = current + 1
}


// Целочисленное деление /
// Остаток от деления %
