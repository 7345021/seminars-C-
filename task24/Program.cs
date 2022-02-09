//Найти кубы чисел от 1 до N
int InPut(string message)
{
    Console.WriteLine(message);
    string num1 = Console.ReadLine();
    return int.Parse(num1);
}
int[] InitArray(int number)
{
    int[] array = new int[number];
    array[0]=1;
    for (int i = 1; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
int b = InPut("Введите число >1: ");
int [] array = InitArray(b);
PrintArray(array);

