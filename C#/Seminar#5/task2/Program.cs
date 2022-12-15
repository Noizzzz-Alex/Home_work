/*
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(0, 1000);
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

int[] array = InitArray(dimension);
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int GetEven(int[] array)
{
    int unevenSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            unevenSumm = unevenSumm + array[i];
       
    }

    return (unevenSumm);
}

int evenSumm = GetEven(array);
PrintArray(array);
Console.WriteLine($"Сумма нечетных:{evenSumm}");