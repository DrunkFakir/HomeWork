﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintCollumsAverage(int[,] matrix)
{
    Console.Write("Среднее арифметическое столбцов массива: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int collumSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            collumSum = collumSum + matrix[i, j];
        }
        double average = collumSum / (double)matrix.GetLength(0);
        double averageRounded = Math.Round(average, 2, MidpointRounding.AwayFromZero);
        Console.Write(averageRounded + "; ");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
PrintCollumsAverage(array2d);

