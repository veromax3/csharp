// Задача 1. Написать программу, которая ищет квадрант, в котором находится заданная пользователем точка
/*

int GetQuadrant(int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    if(x < 0 && y > 0) quadNum = 2;
    if(x < 0 && y < 0) quadNum = 3;
    if(x > 0 && y < 0) quadNum = 4;
    return quadNum;
}

Console.Write("Input the first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(xA, yA);

if(result == 0)
{
    Console.WriteLine("Your point is on the axes");
}
else
{
    Console.WriteLine($"Your point is on {result} quadrant");
}

*/

// Самостоятельная работа 1. Напишите программу, которая по заданному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти.

/*
void Points(int Quadrant)
{
    if(Quadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if(Quadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if(Quadrant == 3) Console.WriteLine("x < 0, y < 0");
    else if(Quadrant == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("x = 0, y = 0");
}

Console.WriteLine("Input quadrant: ");
int point = Convert.ToInt32(Console.ReadLine());
Points(point);
*/


// Самостоятельная работа 2. Написать программу, которая получает на входе число N и вывести квадраты чисел от 1 до N

/*

void SquareNum(int N)
{
    int count = 1;
    while(count <= N)
    {
        int square = count * count;
        count++;
        Console.Write(square + ", ");
    }
}

Console.WriteLine("Input a number: ");
int Num = Convert.ToInt32(Console.ReadLine());
SquareNum(Num);

*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
/*
double Distance(double xA, double yA, double xB, double yB)
{
    double L1 = xB - xA;
    double L2 = yB - yA;
    double result = Math.Round(Math.Sqrt(Math.Pow(L1, 2) + Math.Pow(L2, 2)), 1);

    return result;
}

Console.WriteLine("Input coordinate xA: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate yA: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate xB: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

double Result = Distance(xA, yA, xB, yB);
Console.WriteLine($"Length between 2 points is {Result}");

*/





