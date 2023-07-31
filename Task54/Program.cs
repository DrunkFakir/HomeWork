// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray(int[,] my_array)
{
    for (int j = 0; j < my_array.GetLength(0); j++)
    {
        for (int k = 0; k < my_array.GetLength(1); k++)
        {
            for (int i = 0; i < my_array.GetLength(1) - 1; i++)
            {
                if (my_array[j, i] < my_array[j, i + 1])
                {
                    int temp = my_array[j, i];
                    my_array[j, i] = my_array[j, i + 1];
                    my_array[j, i + 1] = temp;
                }
            }
        }

    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[,] array2d = CreateMatrixRndInt(5, 6, 0, 10);
PrintMatrix(array2d);
SortArray(array2d);
PrintMatrix(array2d);
