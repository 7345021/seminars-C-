//Задача №36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arr = new int[20];
Random myRandom = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = myRandom.Next(100, 1000);
    Console.WriteLine(arr[i]);
}

void Search()
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
            count++;
    }
    Console.WriteLine($"Количество четных чисел массива равно {count}");


    Console.WriteLine($"Количество нечетных чисел массива равно {arr.Length - count}");

}
Search();