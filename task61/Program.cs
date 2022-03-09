//Задача 61: Найти произведение двух матриц
int[,] a = new int[3, 3]; //первая матрица
int[,] b = new int[3, 3];//вторая матрица
int[,] c = new int[3, 3];//третья матрица(результат умножения первых 2-ч матриц)
Random rand = new Random();

//присваиваем значения матрицам(массивам)
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = rand.Next(1, 2);

        Console.Write($" {a[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        b[i, j] = rand.Next(1, 3);
        Console.Write($" {b[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
// алгоритм перемножения 
//и вывода получившейся матрицы
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int k = 0; k < c.GetLength(1); k++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            c[i, k] += a[j, k] * b[i, j];
        }
        Console.Write($" {c[i, k]} ");
    }
    Console.WriteLine();
}
//Console.ReadLine();

