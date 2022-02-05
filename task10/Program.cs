// показать вторую цифру трехзначного числа.
int GetNumber()//объявили функцию
{
    int randomNumber = new Random().Next(100, 1000);//тело
    return randomNumber;
}
int number = GetNumber();//вызвали функцию
Console.WriteLine($"сгененрированное число: {number}");
int SecondDigit()//объявили новую функцию
{
    int result = (number % 100) / 10;
    return result;
}
int secondNumber = SecondDigit();//вызвали функцию
Console.WriteLine($"цифра во втором разряде: {secondNumber}");
