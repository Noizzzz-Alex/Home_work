/*
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }

    return result;
}


double GetDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    //D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

double x1 = GetNumber("Ввведите координату x первой точки ");
double y1 = GetNumber("Ввведите координату y первой точки ");
double z1 = GetNumber("Ввведите координату z первой точки ");

double x2 = GetNumber("Ввведите координату x второй точки ");
double y2 = GetNumber("Ввведите координату y второй точки ");
double z2 = GetNumber("Ввведите координату z второй точки ");

double distance = GetDistance(x1,x2,y1,y2,z1,z2);
Console.WriteLine($"Координаты первой точки {x1},{y1},{z1}");
Console.WriteLine($"Координаты второй точки {x2},{y2},{z2}");
Console.WriteLine($"Расстояние от первой точки до второй = {distance}");