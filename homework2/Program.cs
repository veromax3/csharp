//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.

int thirdSign(int num)
{
    while(num / 1000 >= 1)

        {
            num = num / 10;
        }

    if((num / 1000 == 0)&&(num % 1000 > 100))

    {    
        int result = num % 10;
        return result;
    }

    else
    {
        return -1;
    }
        
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdSign = thirdSign(number);
Console.WriteLine("The third sign of your number is: " + ThirdSign);