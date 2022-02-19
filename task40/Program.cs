//Задача№40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arr = new double[5];
Random myRandom = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = myRandom.Next(-10, 10) + myRandom.NextDouble();//заполнили массив вещ.числами (-10 до 10)
    Console.WriteLine(arr[i]);
}
double minNum = arr[0];
int minValue = (int)minNum;
double maxNum = arr[0];
int maxValue = (int)maxNum;
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < minNum)
    {
        minNum = arr[i];
    }
    if (arr[i] > maxNum)
    {
        maxNum = arr[i];
    }

}
Console.Write($"Минимальный элемент:{minNum}");
Console.WriteLine();
Console.Write($"Максимальныйэлемент:{maxNum}");
void Delta()
{

    double res = maxNum - minNum;
    Console.WriteLine();
    Console.Write($"Разность MAX и MIN равна:{res}");
}
Delta();