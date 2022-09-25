/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int i, remain = 0, newNumber = 0;
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32((Console.ReadLine()));
for (i = number; i > 0; i = (i / 10))
{
    remain = i % 10;
    newNumber = (newNumber * 10) + remain;
}
if (newNumber == number)
{
    Console.WriteLine($"Число {number} является палиндромом!", number);
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом!");
}
