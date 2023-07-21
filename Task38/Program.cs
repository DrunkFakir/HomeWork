// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * rnd.Next(min, max);
        arr[i] = Math.Round(arr[i], 2, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

double MaxElement(double[] myArray)
{
    double maxNumber = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (maxNumber < myArray[i]) maxNumber = myArray[i];
    }
    return maxNumber;
}

double MinElement(double[] myArray)
{
    double minNumber = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if (minNumber > myArray[i]) minNumber = myArray[i];
    }
    return minNumber;
}

double NumberDifference(double maxNumber, double minNumber)
{
    double numDif = maxNumber - minNumber;

    return numDif;
}

double[] array = CreateArrayRndDouble(10, 10, 100);
PrintArray(array);
double maxN = MaxElement(array);
double minN = MinElement(array);
double numberDifference = NumberDifference(maxN, minN);
Console.Write($"-> {numberDifference}");