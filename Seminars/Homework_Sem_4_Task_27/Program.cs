/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int number = new Random().Next(10, 999999);
Console.Write($"Введите произвольное число: {number}");
int sum = 0;
for (int i = number; i > 0; i = (i / 10))
{
    int remain = i % 10;
    sum = sum + remain;
}
Console.WriteLine();

Console.WriteLine($"Сумма цифр в числе {number} равна {sum}!");