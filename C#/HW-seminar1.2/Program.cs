// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);

if (N<0)
{
    for (int i = -2; i >= N; i-=2)
 {
    Console.Write($"{i},");
 }
}


if (N>0)
{
    for (int i = 2; i <= N; i+=2)
 {
    Console.Write($"{i},");
 }
}

if (N==0)
{
    Console.WriteLine("0");
}