// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число A в целую степень B с помощью рекурсии. 

Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numB = Convert.ToInt32(Console.ReadLine());

int pow = Pow(numA, numB);
Console.WriteLine($"{pow}");

int Pow(int num1, int num2)
{
    if (num2 == 0) return 1; // 3-5, 3-4, 3-3, 3-2, 3-1 
    return num1 * Pow(num1, num2 - 1); // 3*3*3*3*3*1 = 343
}

