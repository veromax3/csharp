﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int RaiseToPower(int A, int B)
{
    int result = 1;
    int power = 0;


    if (B != 0)
    {
        while (power < B)
        {
            result = result * A;
            power++;
        }
         return result;
    }    
   

    else
    {
        result = 1;
        return result;
    }
}

Console.WriteLine("Input a number: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a power: ");
int numB = Convert.ToInt32(Console.ReadLine());

int raise = RaiseToPower(numA, numB);
Console.WriteLine($"The result of raising number {numA} to the power {numB} is: {raise}");