//Задача 54: В матрице чисел найти сумму элементов главной диагонали
var arr = new int[5, 5];
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
void NumberSum()
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + arr[i, j];
                
            }
           

        }

    } Console.WriteLine($"Сумма чисел главной диагонали равна: {result} ");
}

FillArray();
PrintArray();
NumberSum();