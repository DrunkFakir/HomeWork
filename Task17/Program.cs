// Напишите программу, которая принимает на вход координаты точки ( x и y), 
// причем они не равны нулю и выдаёт номер четверти плоскости, в которой 
// находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X:");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = GetQuarter(xCoordinate, yCoordinate);
string result = quarter > 0 
             ? $"Указанные координаты соответствуют четверти -> {quarter}" 
            : "Введены некорректные координаты";

Console.WriteLine(result);

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}