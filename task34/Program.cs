// Задача№34. Написать программу замену элементов массива на противоположные.
int[]arr=new int[5];
Random myRandom=new Random();
for(int i=0; i<arr.Length; i++)
{
    arr[i]=myRandom.Next(-5, 5);
    Console.WriteLine(arr[i]);
}
Console.WriteLine();
for(int i=0; i<arr.Length; i++)
{
    arr[i]=arr[i]*-1;
    Console.WriteLine(arr[i] );
}
