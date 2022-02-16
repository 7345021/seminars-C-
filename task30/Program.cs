//  Задача №30. Показать кубы чисел, заканчивающихся на четную цифру

int[] myArray = new int[10];//объявили массив
Random myRandom = new Random();//объявили рандомный метод
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = myRandom.Next(1, 10);//заполнили массив числами.
    Console.Write(myArray[i]);//вывели массив на консоль
    Console.WriteLine();
}
double value = 1;//ввели переменную
double power=3;// ввели переменную(кубическая степень)
for (int i = 0; i < myArray.Length; i++) //цикл for
{
    value = Math.Pow(myArray[i], power); 
    Console.WriteLine($"получили куб числа: {value}");
    double result=value % 2;
    if(result==0)
    Console.WriteLine($"Куб числа {myArray[i]} заканчивается на четную цифру");
}
