// Удалить вторую цифру трехзначного числа.
int GetNumber() //объявили функцию
{
    int randomNumber=new Random().Next(100, 1000); 
    return randomNumber;
}
int number=GetNumber();
Console.WriteLine($"случайное число: {number}");

int firstDigit=number/100;
int thirdDigit=number %10;
Console.WriteLine($"удален второй разряд: {firstDigit}_{thirdDigit}");

