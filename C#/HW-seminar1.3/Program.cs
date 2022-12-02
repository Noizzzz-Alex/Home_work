/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


*/
Console.WriteLine("Введите 1-e число");
int NumSTR = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите 2-e число");
int NumSTR1 = int.Parse(Console.ReadLine()??"");

if(NumSTR > NumSTR1)
    
    Console.WriteLine($"Max = {NumSTR}");

else

    Console.WriteLine($"Max = {NumSTR1}");
