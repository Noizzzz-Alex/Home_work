﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите 3-х значное число");
int NumSTR1 = int.Parse(Console.ReadLine()??"");
int max = 0;


max = NumSTR1 % 100 / 10;
Console.WriteLine($"Max = {max}");

