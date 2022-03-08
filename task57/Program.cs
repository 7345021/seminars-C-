//Задача 57: Написать программу, которая упорядочивает
// по убыванию элементы каждой строки двумерной массива.
var arr = new int[4, 4];
Random randomNumber = new Random();
void FillArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = randomNumber.Next(-10, 10);
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
void SortStr()
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
            if((arr[i, j] >= arr[i, k]) )
            {
               int temp = arr[i, j];
                arr[i, j] = arr[i, k];
                arr[i, k] = temp;
            }   
            } 
        }
    }
}
FillArray();
PrintArray();
SortStr();
Console.WriteLine();
PrintArray();