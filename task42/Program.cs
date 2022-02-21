//Задача 42: Определить сколько чисел больше 0 введено с клавиатуры.


Console.Write("Введите количество элементов массива: ");

int elementsCount = int.Parse(Console.ReadLine());
int[] arr = new int[elementsCount];
// Console.WriteLine("Вывод массива");


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = 0;
    Console.Write($"Введите элемент массива под индексом {i}:  ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
void Search()
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item > 0)
            count++;
    }
    Console.WriteLine($"Количество чисел больше нуля {count}");
}
Search();
