/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите число A: ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int namberB = Convert.ToInt32(Console.ReadLine());
int resultPower = 1;
for (int i = 0; i < namberB; i++)
{
    resultPower = resultPower * namberA;
}

Console.WriteLine($"Число {namberA} в степени {namberB} равно {resultPower}!");
