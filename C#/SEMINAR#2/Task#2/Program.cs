/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число");

int numSTR1 = int.Parse(Console.ReadLine()??"");
int dig = 0;

if (100 <= numSTR1 && numSTR1 <= 999)
{
dig = numSTR1 % 10;
Console.WriteLine($"Третья цифра числа = {dig}");
}

if (0 <= numSTR1 && numSTR1 <= 99)
{
Console.WriteLine("Третья цифра отсутсвует");
}


if (numSTR1 > 999)
{
while (numSTR1 > 999)
    {
        numSTR1 = numSTR1 / 10;
    }
numSTR1 = numSTR1 % 10;
Console.WriteLine($"Третья цифра числа = {numSTR1}");
}