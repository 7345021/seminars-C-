int InPut(string message)
{
    Console.WriteLine(message);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}
int x1 = InPut("Введите координату X1");
int x2 = InPut("Введите координату X2");
int y1 = InPut("Введите координату Y1");
int y2 = InPut("Введите координату Y2");
int z1 = InPut("Введите координату Z1");
int z2 = InPut("Введите координату Z2");


double Distance()
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    double X = Math.Pow(x, 2);
    double Y = Math.Pow(y, 2);
    double Z = Math.Pow(z, 2);
    double Dis = (X + Y + Z);
    double res = Math.Sqrt(Dis);
    Console.WriteLine($"Расстояние между двумя точками в пространстве 3D: {res} ед");
    return (res);
}

Distance();