//Задача 67: Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"
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
for (int i = leftNumber; i <= rightNumber; i++)
{
    Console.Write($"{i} ");
}
