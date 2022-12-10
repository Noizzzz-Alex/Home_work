/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result) && result != 0)
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

double number = GetNumber("введите число");
double pow = GetNumber("в какую степень желаете возвести?");
double multi = Math.Pow(number, pow);
Console.WriteLine($"{number} ^{pow} = {multi}");