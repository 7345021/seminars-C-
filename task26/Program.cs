// Задача 26.Возведите число А в натуральную степень B используя цикл.

int InPut(string message)
{
    Console.WriteLine(message);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}
int number = InPut("Введите число А (основание степени): ");
int degree = InPut("Введите число В (показатель степени): ");

double result = number;

for (int i = 1; i < degree; i++)
{
    result *= number;
}
Console.Write($"{number}^{degree}={result}");