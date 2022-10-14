/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите число M: ");
int userNumberStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberEnd = Convert.ToInt32(Console.ReadLine());
int summ = 0;

SumNumbers(userNumberStart, userNumberEnd, summ);
void SumNumbers(int start, int end, int summ)
{
    summ = summ + end;
    if (start >= end)
    {
        Console.Write($"Сумма элементов от {start} до {userNumberEnd} равна {summ}!");
        return;
    }
    SumNumbers(start, end - 1, summ);
}