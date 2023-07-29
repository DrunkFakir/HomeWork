// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" |");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите номер строки");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

if (line > array2d.GetLength(0) || column > array2d.GetLength(1) || line < 0 || column < 0)
{
    Console.WriteLine("");
    Console.WriteLine("Tакого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {line} строки и {column} столбца равно {array2d[line - 1, column - 1]}");
}
