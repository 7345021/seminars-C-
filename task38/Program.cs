// Задача №38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arr = new int[10];
Random myRandom = new Random();
for (int i = 0; i < arr.Length; i++)
{
     arr[i] = myRandom.Next(1, 10);
     Console.WriteLine(arr[i]);
}
int sum = 0;

for (int i = 1; i <= arr.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + arr[i];
        Console.WriteLine($"ЭЛЕМЕНТ МАССИВА С ОТРИЦАТЕЛЬНЫМ ИНДЕКСОМ: {arr[i]}");
    }
}
Console.WriteLine($"Сумма элементов:{sum}");
