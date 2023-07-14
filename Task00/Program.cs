// Напишите программу, которая:
// 1. На вход принимает число
// 2. Выдаёт его квдрат
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
//string str = Console.Readline()
//string str = Console.ReadLine();
Console.WriteLine("Ведите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");