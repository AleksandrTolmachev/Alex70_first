﻿/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого. 
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет
*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber * secondNumber )
{
    Console.WriteLine($"Да! Число {firstNumber} является квадратом {secondNumber}!");
}
else if (secondNumber == firstNumber * firstNumber)
    {
        Console.WriteLine($"Да! Квадрат числа {firstNumber} действительно равен {secondNumber}!");
    }
else
{
    Console.WriteLine("Ни одно число не является квадратом другого!");
}