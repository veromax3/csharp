// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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