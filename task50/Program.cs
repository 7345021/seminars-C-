////Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.
var arr = new int[4, 6];
Random randomNumber = new Random();
void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(-100, 100);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SearchNumber()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0)
                arr[i, j] = -1 * arr[i, j];
            Console.Write($"{arr[i, j]} ");
        }
    Console.WriteLine();
    }
    
}
FillArray();
PrintArray();
Console.WriteLine();
SearchNumber();