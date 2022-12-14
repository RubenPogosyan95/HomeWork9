// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
System.Console.WriteLine(ShowNumbers(1, 15, sum));
int ShowNumbers(int M, int N, int sum)
{
    if (M == N + 1) return sum;
    return (sum + M + ShowNumbers(M + 1, N, sum));
}