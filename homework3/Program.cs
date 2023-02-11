// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*

bool Palindrome(int number)
{   
    int CopyNum = number;
    int newNum = 0;
    int remainder = number % 10;
    while (number > 0)
    {
        newNum = remainder + (newNum * 10);
        number = number / 10;
        remainder = number % 10;
    }
    
    if(CopyNum == newNum) 
    {
        bool palindrome = true;
        return palindrome;
    }

    else 
    {
        bool palindrome = false;
        return palindrome;
    }    
}

Console.WriteLine("Input a number: ");
int numbers = Convert.ToInt32(Console.ReadLine());

bool result = Palindrome(numbers);
Console.WriteLine($"{numbers} is palindrome: {result}");


*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double L1 = xB - xA;
    double L2 = yB - yA;
    double L3 = zB - zA;
    double result = Math.Round(Math.Sqrt(Math.Pow(L1, 2) + Math.Pow(L2, 2) + Math.Pow(L3, 2)), 2);
    return result;
}

Console.WriteLine("Input coordinate xA: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate yA: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate zA: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate xB: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate yB: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double Result = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance between 2 points in 3D is {Result}");
