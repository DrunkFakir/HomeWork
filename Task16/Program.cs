// Напишите программу, котрая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> Да
// 25, 5 -> Да
// 8, 9 -> Нет

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool res = IsSquareTwoNumbers(firstNumber, secondNumber);
Console.WriteLine(res ? "Да" : "Нет");

bool IsSquareTwoNumbers(int firstNum, int secondNum)
{
    // if (firstNum == secondNum * secondNum || secondNum == firstNum * firstNum)
    return firstNum == secondNum * secondNum || secondNum == firstNum * firstNum;
}