// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 
// 45 -> 9 

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     return n * FactorialRec(n - 1);   Нахождение факториала
// }
// Console.WriteLine(FactorialRec(10));

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigit(number);
Console.WriteLine($"{sum}");

int SumDigit(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDigit(n / 10);  //  (К примеру число) 453 -> 45 -> 4 | 0 + 4 % 10 + 45 % 10 + 453 % 10 = 12
}
