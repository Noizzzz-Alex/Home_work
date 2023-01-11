/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

double[] InitArray(int dimension)
{
    double[] array = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.NextDouble();
    }

    return array;
}

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

int dimension = GetNumber("Какой размер массива?");

double[] array = InitArray(dimension);
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
(double, double) GetMaxMinNumber(double[] array)
{
    double min = array[0];
    double max = array[1];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < max)
        {
            array[i] = max;
        }
        if (array[i] > min)
        {
            array[i] = min;
        }
    }

    return (max, min);
}


PrintArray(array);
(double min, double max) = GetMaxMinNumber(array);
double diffNumber = max - min;
Console.WriteLine($"Min ={min}, Max ={max}, Diff ={diffNumber}");