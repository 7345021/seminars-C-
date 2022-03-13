//Задача 65: Спирально заполнить двумерный массив
Console.WriteLine("Введите количество элементов в строке");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество элементов в cтолбце");
int m = int.Parse(Console.ReadLine());
int[,] arr = new int[m, n];
int k = 1;
int t = 0;
int i, j = 0;
int n1 = n;
int m1 = m;

while (k <= n1 * m1)
{
    for (i = t; i < n; i++)
        arr[j, i] = k++;
    j = n - 1;
    for (i = t + 1; i < m; i++)
        arr[i, j] = k++;
    j = m - 1;
    for (i = n - 2; i >= t; i--)
        arr[j, i] = k++;
    j = t;
    for (i = m - 2; i > t; i--)
        arr[i, j] = k++;
    n--;
    m--;
    t++;
    j = t;
}
for (i = 0; i < arr.GetLength(0); i++)
{
    for (j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0,3}", arr[i, j]);
        Console.WriteLine();
}

//"{0,3} "