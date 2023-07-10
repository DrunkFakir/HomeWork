// Напишите програму, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого трёхзначного числа.
// 245 -> 25

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int resultDigit = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Ответ -> {result}");

int result = RemoveSecondDigit(number);
Console.WriteLine($"Ответ -> {result}");

int RemoveSecondDigit(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int resultDigit = firstDigit * 10 + thirdDigit;
    return resultDigit;
}
