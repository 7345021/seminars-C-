//Задача 44. Найти точку пересечения двух прямых заданных 
//уравнением y = k1 * x + b1, y = k2 * x + b2, 
//b1 k1 и b2 и k2 заданы.
double k1 = -6;
double b1 = 9;
double k2 = 2;
double b2 = -3;
if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
double x = (b1 - b2) / (k2 - k1);
Console.WriteLine($"Х равен {x}");