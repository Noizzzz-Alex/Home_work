/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите 1-e число");
int NumSTR1 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите 2-e число");
int NumSTR2 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите 3-e число");
int NumSTR3 = int.Parse(Console.ReadLine()??"");

if(NumSTR3 < NumSTR1 && NumSTR2 < NumSTR1)
    
    Console.WriteLine($"Max = {NumSTR1}");

if(NumSTR3 < NumSTR2 && NumSTR1 < NumSTR2)
    
    Console.WriteLine($"Max = {NumSTR2}");

if(NumSTR1 < NumSTR3 && NumSTR2 < NumSTR3)
    
    Console.WriteLine($"Max = {NumSTR3}");
