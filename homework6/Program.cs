// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

Console.WriteLine("Input number of elements: ");
int NumEl = Convert.ToInt32(Console.ReadLine());
int counter = 0;
for(int i = 0; i < NumEl; i++)
{
    Console.WriteLine($"Input {i + 1} element: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
        counter++; 
}
Console.WriteLine($"The number of elements entered by the user is {counter}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void LineIntersection(double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;;
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("The lines are identical, intersection points are exactly the same");

    else if (k1 == k2)
    {
        Console.WriteLine("The lines are parallel, the intersection point is 0");
    }

    else 
    {
        x = (b1 - b2)/(-k1 + k2);
        y = k1 * x + b1;
        Console.WriteLine($"The intersection point is ({x}; {y})");
    }
}


Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

LineIntersection(k1, b1, k2, b2);
