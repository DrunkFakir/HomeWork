// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


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

void ReplaceFirstLastRows(int[,] myArray)
{
    int firstRow = 0;
    int lastRow = myArray.GetLength(0) - 1;

    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        int temp = myArray[firstRow, j];
        myArray[firstRow, j] =  myArray[lastRow, j];
        myArray[lastRow, j] = temp;
    }
}

int[,] array2d = CreateMatrixRndInt(5, 6, -100, 100);
PrintMatrix(array2d);
ReplaceFirstLastRows(array2d);
PrintMatrix(array2d);