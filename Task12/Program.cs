// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 - > не кратно, остаток 4
// 16, 4 - > кратно

Console.Write("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int reminder = IsMultiplicity(firstNum, secondNum);
// if (reminder == 0) Console.Write("Кратно");
// else Console.Write($"Не кратно, остаток -> {reminder}");
Console.Write(reminder == 0? "Кратно" : $"Не кратно, остаток {reminder}");

int IsMultiplicity(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}