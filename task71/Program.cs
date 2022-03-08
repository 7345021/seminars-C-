﻿//Задача 71: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(n,m) = 29
int A(int n, int m)
{


    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n, m);
}
Console.Write($" Значение функции Аkkермана: {A(3, 2)}");
