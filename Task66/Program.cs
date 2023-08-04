// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber < 0 || secondNumber < 0)
{
    Console.WriteLine("Одно или оба числа введены не корректно");
    return;
}

int sum = NaturalNumberSum(firstNumber, secondNumber);
Console.WriteLine($"Сумма натуральных элементов в промежутке от первого до второго числа -> {sum} ");

int NaturalNumberSum(int m, int n)
{
    if (m > n)
    {
       return m + NaturalNumberSum(m - 1, n);
    }
    else if (m < n)
    {
       return m + NaturalNumberSum(m + 1, n);
    }
    return m;
}
