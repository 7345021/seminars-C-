//Задача 28: Подсчитать сумму цифр в числе.
int GetNumber()//объявили метод
{
    int randomNumber = new Random().Next(100, 1000000);//тело
    return randomNumber;
}
int number = GetNumber(); //вызвали метод

Console.WriteLine($"Случайно полученное число: {number}");

int Summ(int value) //объявили метод
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value = value / 10;
    }
    return sum;
}
int value = number;//объявили переменную
int sum = Summ(value);//вызвали метод
Console.WriteLine($"Сумма всех цифр числа:{sum}");
