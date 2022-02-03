int[] array = { 1, 2, 46, 4, 5, 6, 7, 8, 9, 26 };
int c;
int n = array.Length;
int index = 0;


while (index <= n)
{
    if (array[index] % 2 == 0)
    {
        c = array[index];
        Console.WriteLine(c);
    }

    index++;
}

