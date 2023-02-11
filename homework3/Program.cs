// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


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


