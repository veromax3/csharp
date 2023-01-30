// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*

Console.Write("Input the first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The first number is: " + FirstNumber);

Console.Write("Input the second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The second number is: " + SecondNumber);

if(FirstNumber > SecondNumber)
{
    Console.Write("The first number is greater than the second number");
}
else
{
    Console.Write("The first number is less than the second number");
}

*/






// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

/*

Console.Write("Input the first number: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The first number is: " + FirstNumber);

Console.Write("Input the second number: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The second number is: " + SecondNumber);

Console.Write("Input the third number: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The third number is: " + ThirdNumber);

int MaxNumber;

if(FirstNumber > SecondNumber)
{
    MaxNumber = FirstNumber;
}

else 
{
    MaxNumber = SecondNumber;
}

if (MaxNumber < ThirdNumber)
{
    MaxNumber = ThirdNumber;
    Console.Write("The maximum number is " + MaxNumber);
}
else 
{
    Console.Write("The maximum number is " + MaxNumber);
}

*/






// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Your number is: " + number);

int remainder = number % 2; 

if(remainder == 0)
{
    Console.WriteLine("Yes, your number is even");
}
else
{
    Console.WriteLine("No, your number is odd");
}

*/






// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your numbers is: " + number);

int CurrentNumber = 1;

while (CurrentNumber <= number)
{   
    int remainder = CurrentNumber % 2;

    if (remainder == 0)
    {
        Console.Write(CurrentNumber + ", ");
        CurrentNumber = CurrentNumber + 1;
    }
    else
    {
       CurrentNumber = CurrentNumber + 1;
    }
}
