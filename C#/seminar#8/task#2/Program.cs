/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
//int SumRec()

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void GetSumLineMatrix(int[,] matrix)
{
    int minIdLine = 0;
    int sumMin = 0;
    int sumLine = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumMin += matrix[0,i]; 
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumLine += matrix[i, j];
        {
            
            if (sumMin > sumLine)
            {
                sumMin = sumLine;
                minIdLine = i;
            }
            sumLine = 0;



        }

    }
    Console.WriteLine($"Minimal sum = {sumMin} Line {minIdLine + 1}");

}

int[,] matrix = InitMatrix(10, 5);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
GetSumLineMatrix(matrix);
