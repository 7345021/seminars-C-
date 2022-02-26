//Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.
var arr = new int[4, 4];
Random randomNumber = new Random();
void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(1, 10);
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
            if (i % 2 == 0 && j % 2 == 0)
                arr[i, j] = arr[i, j] * arr[i, j];
            Console.Write($"{arr[i, j]} ");

        }
        Console.WriteLine();
    }

}
FillArray();
PrintArray();
Console.WriteLine();
SearchNumber();
