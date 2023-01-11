/*Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру дня недели от 1 до 7");
int numSTR1 = int.Parse(Console.ReadLine()??"");
while(numSTR1> 7 || numSTR1 <= 0)
{
    Console.WriteLine("Число введено неверно");
    Console.WriteLine("Введите цифру дня недели от 1 до 7");
    numSTR1 = int.Parse(Console.ReadLine()??"");
}
if (numSTR1 > 5 && numSTR1 <= 7)
{
    Console.WriteLine("Да, этот день является выходным");
}
else
{
    Console.WriteLine("Нет, этот день является будним");
}