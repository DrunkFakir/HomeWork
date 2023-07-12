// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.Write("Не трёхзначное число");
    return;
}
string stringNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);