/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber(string message)
{
    int result;
    int count = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Ввведите следующиее число. Для завершения введите любой символ.");
            if (result > 0)
            {
                count++;
            }
        }
        else
        {
            break;
        }
    }

    return count;
}
int number = GetNumber("Введите число, или введите любой символ если закончили ввод.");
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {number}");


