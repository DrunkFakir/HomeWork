// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл полььзователь.
// 0, 7, 8, -2, -2 -> 2

Console.Write("Введите количество элементов массива: ");
int mass = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[mass];

void Mas(int mass)
{
    for (int i = 0; i < mass; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }

}

int Quantity(int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}

Mas(mass);
Console.Write($"\n Чисел больше нуля: { Quantity(Array)}");