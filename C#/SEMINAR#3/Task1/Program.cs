/*
Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int number = GetNumber("Введите пятизначное число");
int GetNumber(string message)
{
    bool isCorrect = false;
    bool isCorrect1 = false;
    
    int result = 0;

    while (!isCorrect && !isCorrect1)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0 && result >= 11111 && result <= 99999)
        {
            isCorrect = true;
            isCorrect1 = true;
        }
        else
        {
            Console.WriteLine("Введено некорректное число или 0. Введите корректное число");
        }
    }
   
    return result;
}


int i = 0;
int firstDigit, secondDigit, fourDigit, fiveDigit;
firstDigit = number / 10000;
secondDigit = number / 1000 % 10;
fourDigit = number % 100 / 10;
fiveDigit = number % 10;
//Console.Write($"{firstDigit}, {secondDigit}, {fourDigit}, {fiveDigit} ");

if (firstDigit == fiveDigit && secondDigit == fourDigit)
{
   i++;
}


if (i == 1)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}
