//найти третью цифру числа или сообщить, что ее нет.
int GetRandom()
{
    int digit = new Random().Next(0, 1000);
    return digit;
}
int number = GetRandom();
Console.WriteLine($"любое случайное число: {number}");

int result=number / 10;
if (result >= 10)
{
   Console.WriteLine($"третья цифра: {number%10}");
}
else 
{
    Console.WriteLine($"Третья цифра отсутствует");
}