﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int all = 2;

if(number > 1)
{
    while(all <= number)
    {
        Console.Write(all + " ");
        all = all + 2;
    }
}