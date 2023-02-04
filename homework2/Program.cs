//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.

int thirdSign(int num)
{   
    while(num / 1000 >= 1)

        {
            num = num / 10;
        }

    if((num / 1000 == 0)&&(num % 1000 >= 100))

    {    
        int result = num % 10;
        return result;
    }

    else
    {
        return -1;
    }
        
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdSign = thirdSign(number);

if(ThirdSign == -1) 
{
    Console.WriteLine($"The third sign of your number is: {ThirdSign}\nINPUT ERROR!");
}

else

{   
    Console.WriteLine("The third sign of your number is: " + ThirdSign);
}

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
 

int threeDigitNum(int Num3Signs)
{
    Num3Signs = (Num3Signs % 100) / 10;
    return Num3Signs;
}

Console.Write("Input three-digit number: ");
int ThreeDigitNum = Convert.ToInt32(Console.ReadLine());

while (( ThreeDigitNum > 999) || (ThreeDigitNum < 100))
{
    Console.Write($"INPUT ERROR!\nInput three-digit number: ");
    ThreeDigitNum = Convert.ToInt32(Console.ReadLine());
}

int Result = threeDigitNum(ThreeDigitNum);
Console.WriteLine($"The second sign of number {ThreeDigitNum} is: {Result}");


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

bool week(int arg)
{   
    if((arg == 6)||(arg == 7))
        {
             bool weekday = true;
             return weekday;
        }
    else
    {
        bool weekday = false;
        return weekday;
    }    
}

Console.Write("Input a number: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

bool Day = week(DayNumber);
Console.WriteLine($"This number ({DayNumber}) means day off: {Day}");
