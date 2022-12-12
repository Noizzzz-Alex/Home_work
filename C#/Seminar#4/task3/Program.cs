/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int GetNumber(string message)//будет выводить сообщение
{
    bool isCorrect = false;//объявление переменных
    int result = 0;

    while (!isCorrect)//проверка логической переменной на ложь и правду
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))//безопасное преобразование стринга в инт с выводом результата
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
int [] array = new int[8];
/*
int number1 = GetNumber("input number #1");
int number2 = GetNumber("input number #2");
int number3 = GetNumber("input number #3");
int number4 = GetNumber("input number #4");
int number5 = GetNumber("input number #5");
int number6 = GetNumber("input number #6");
int number7 = GetNumber("input number #7");
int number8 = GetNumber("input number #8");
*/
// Console.WriteLine(array);


for (int i = 0; i < array.Length; i++)
{
    int number = GetNumber("Input number");
    array[i] = number;
    
}
Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}] ");