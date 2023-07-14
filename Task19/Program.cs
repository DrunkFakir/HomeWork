// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное положительное число");
int number = Convert.ToInt32(Console.ReadLine());

bool num = PalindromeCheck(number);
Console.WriteLine(num ? "Да" : "Нет");

bool PalindromeCheck(int num)
{
    if (num < 0) num = -num;
    if (num > 9999 && num < 100000)
    {
        int digit1 = num / 10000;
        int digit2 = num / 1000 % 10;
        int digit3 = num / 10 % 10;
        int digit4 = num % 10;
        if (digit1 == digit4 && digit2 == digit3)
        return true;
    }
    return false;
}