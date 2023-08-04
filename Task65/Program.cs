// Задайте значение M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8" 

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine("Не корректное число");
    return;
}

NaturalNumbersRange(firstNumber, secondNumber);

void NaturalNumbersRange(int m, int n)
{
    if (m > n)
    {
        Console.Write($" {m}");
        NaturalNumbersRange(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($" {m} ");
        NaturalNumbersRange(m + 1, n);
    }
    else Console.Write($" {m}");
}
