/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
double GetNumber(string message)
{
    double result;

    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

double b1 = GetNumber("Введите число В1");
double k1 = GetNumber("Введите число К1");
double b2 = GetNumber("Введите число В2");
double k2 = GetNumber("Введите число К1");
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");