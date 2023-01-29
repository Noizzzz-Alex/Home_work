string[] array = new string[5]{"edwedwe","ede","rfrfw","11d","a"};
string[] arraynew = new string[array.Length];
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] } ");
    }
    Console.WriteLine();
}