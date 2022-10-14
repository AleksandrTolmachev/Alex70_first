/*
Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Write("Введите число M: ");
int userNumberStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberEnd = Convert.ToInt32(Console.ReadLine());

printRange(userNumberStart, userNumberEnd);
void printRange(int start, int end)
{
    if (start == end)
    {

        Console.Write($"{end}, ");
        return;
    }
    printRange(start, end - 1);
    Console.Write($"{end}, ");
}
