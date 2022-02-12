//Задача 20: Задать номер четверти, показать диапазоны для возможных координат
int InPut(string message)
{
    Console.WriteLine(message);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}
void NumberPart(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I Четверть: X>0, Y>0");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("II Четверть: X<0, Y>0");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("III  Четверть: X<0, Y<0");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("IV Четверть: X>0, Y<0");
    }
}
int x = InPut("Введите координату Х: ");
int y = InPut("Введите координату Y: ");
NumberPart(x, y);

