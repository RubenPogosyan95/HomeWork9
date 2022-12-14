﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine(ShowNumbers(5));

string ShowNumbers(int N)
{
    if (N == 1) return N.ToString();
    return (N + " " + ShowNumbers(N - 1));
}