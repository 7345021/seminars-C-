//Задача 69: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 15
//M = 4; N = 8. -> 5

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool checkStatus = true;
    int numberInt = 0;
    while (checkStatus)
    {
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out numberInt))
        {
            checkStatus = (false);
            break;
        }
        else
            Console.WriteLine("Ввели не число");
    }
    return numberInt;
}
int rightNumber = GetNumber("Введите число (N) правую границу диапазона: ");
int leftNumber = GetNumber("Введите число (M) левую границу диапзона: ");

int result = 0;
for (int i = leftNumber; i <= rightNumber; i++)
{
    int sum = i;
    Console.Write($"{sum} ");
    result += sum % 100;
}
Console.WriteLine();
Console.Write($"Сумма чисел в диапазоне от М до N: {result} ");

