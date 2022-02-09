//Дано число обозначающее день недели. 
//Выяснить является номер дня недели выходным.
Console.Write("Введите число от 1 до 7:  ");

//int[] numberWeek = { 1, 2, 3, 4, 5, 6, 7 };
//   0  1  2  3  4  5  6
int number=0;
number =int.Parse (Console.ReadLine());



if (number == 6 || number == 7)
{
    Console.WriteLine($"выходной день {number}");
}
else
    Console.WriteLine($"будний день {number}");