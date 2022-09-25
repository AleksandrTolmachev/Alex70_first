/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = number / 10000;
int result2 = number % 10;
int result3 = (number / 100) % 10;
int result4 = (number / 1000) % 10;
if (result1 == result2 && result3 == result4)
{
    Console.WriteLine("Палиндром!");
}
else
{
    Console.WriteLine("Не палиндром!");
}
