/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ошибка ввода числа. Введите корректное число");
        }
    }

    return result;
}
/*
int GetSumDigit();
{
    int digit = 
}
*/
int number = GetNumber("Input number");
int result = 0;
while(number > 99)
{
    int lastDigit = number % 10;
   
    number = number/10;
    
    result = result + lastDigit;
}
result = (number / 10) + (number%10) + result;
Console.WriteLine(result);