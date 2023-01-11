/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int m = 1;
int n = 15;

 
int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если M = 0
    else if (n == 0) return (m * (m + 1)) / 2;       // Если N = 0
    else if (m == n) return m;                       // Если M=N
    else if (m < n) return n + SumNumbers(m, n - 1); // Если M<N
    else return n + SumNumbers(m, n + 1);            // Если M>N
}

Console.WriteLine(SumNumbers(m, n));