//Задача 63: Сформировать трехмерный массив не повторяющимися двузначными числами
// показать его построчно на экран выводя индексы соответствующего элемента
int[,,] arr = new int[2, 2, 3];
Random randomNumber = new Random();
int y = 0;


void FillArray()
{   
    for (int i = 0; i < arr.GetLength(0); i++)//перебираем "страницы"
    {
        for (int j = 0; j < arr.GetLength(1); j++)//перебираем строки
        {
            for (int k = 0; k < arr.GetLength(2); k++)//перебираем столбцы
            {
                arr[i, j, k] = randomNumber.Next(10, 100);
                int numRand = randomNumber.Next(10, 100);
                if (numRand != arr[i, j, k])
                {
                    
                    y = arr[i, j, k];
                    
                    y++;
                }
                if (numRand == arr[i, j, k])
                    break;
            }
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ");

            }
            Console.WriteLine();

        }

    }
}


FillArray();
PrintArray();
Console.Write("Введите число из нашей матрицы: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            if(n==arr[i, j, k])
            {
                Console.Write($"индекс: {i} {j} {k}");
            }
        }
    }
}
