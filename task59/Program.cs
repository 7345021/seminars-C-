//Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.
var arr = new int[5, 6];
int sum = 0;
int minRowSum = int.MaxValue;
int indexMinRow = 0;
Random randomNumber = new Random();
void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(0, 10);
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
FillArray();
PrintArray();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];//находим сумму элементов строки
        
        
    }
    if (i < indexMinRow)
    {
        i = indexMinRow;
    }

    if (sum < minRowSum)
    {
        minRowSum = sum;
        sum = minRowSum;
        indexMinRow = i;
    }

    Console.WriteLine($"Сумма {(i + 1)} строки равна {sum}");
    sum = 0;//обнуляем полученную сумму

}

for (int j = 0; j < arr.GetLength(1); j++)
{
    Console.Write($"{arr[indexMinRow, j]} ");

}
Console.WriteLine($" Строка с минимальной суммой элементов {minRowSum}, ее №  {indexMinRow + 1} ");
//Console.WriteLine($" инминроу= {indexMinRow + 1}");
//Console.WriteLine($" минсумм= {minRowSum}");