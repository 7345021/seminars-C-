//Задача 46: Написать программу масштабирования фигуры.
// Для примера рассмотрим треугольник.

double InPut(string message)
{
    Console.Write(message);
    string num1 = Console.ReadLine();
    return double.Parse(num1);
}
double x1 = InPut("Введите координату первой вершины треугольника X1: ");
double y1 = InPut("Введите координату первой вершины треугольника Y1: ");
double x2 = InPut("Введите координату второй вершины треугольника X2: ");
double y2 = InPut("Введите координату второй вершины треугольника Y2: ");
double x3 = InPut("Введите координату третьей вершины треугольника X3: ");
double y3 = InPut("Введите координату первой вершины треугольника Y3: ");

double k = InPut("Введите коэффициент масштабирования К: ");
    if(k>1)
    {
        Console.WriteLine("Фигура увеличивается в масштабе");
    }
    else
        Console.WriteLine("Фигура уменьшается в масштабе");
void Scale()
{
    double x1new=x1*k;
    double y1new=y1*k;
    double x2new=x2*k;
    double y2new=y2*k;
    double x3new=x3*k;
    double y3new=y3*k;
   Console.WriteLine($"Новые координаты вершин треугольника:{x1new} {y1new} {x2new} {y2new} {x3new} {y3new} ");
}
Scale();