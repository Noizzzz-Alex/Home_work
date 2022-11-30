//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string numbers = Console.ReadLine();
int N = Convert.ToInt32(numbers);

if (N == 0)

    Console.WriteLine("Неверно введено число");
else
{
if (N % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Чиcло нечетное");
}

