/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}
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

void GetMiddleValue(int[,] matrix)
{
    
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double middleMath = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            middleMath += matrix[j, i];
        }
        middleMath = middleMath / matrix.GetLength(0);
        Console.WriteLine($"Среднее значение столбца {i+1} = {Math.Round(middleMath,2)}");
    }   

    
}


int m = GetNumber("Введите кол-во строк");
int n = GetNumber("Введите кол-во столбцов");
Console.WriteLine();
int[,] matrix = InitMatrix(m, n);

Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
GetMiddleValue(matrix);

