/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ошибка ввода числа. Введите корректное число");
        }
    }

    return result;
}

int number = GetNumber("Введите число");
if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
        int cube = i*i*i;
        // можно написать функцию чтобы она возвращала куб числа, но так проще.
        Console.WriteLine($"{i} ^3 = {cube}");
    }
}
if (number < 0)
{
    for (int i = 1; i >= number; i--)
    {
        if (i == 0)
        {
            i = -1;
        }
        else
        {
            int cube = i*i*i;
            Console.WriteLine($"{i} ^3 = {cube}");
        }
        
    }
}