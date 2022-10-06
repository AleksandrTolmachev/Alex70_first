/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Заданы две прямые, описываемые уравнениями: y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Ведите значение постоянного аргумента уравнений b1 = ");
double argumentb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение постоянного аргумента уравнений k1 = ");
double argumentk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение постоянного аргумента уравнений b2 = ");
double argumentb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите значение постоянного аргумента уравнений k2 = ");
double argumentk2 = Convert.ToInt32(Console.ReadLine());

double variableX = Math.Round((argumentb2 - argumentb1) / (argumentk1 - argumentk2), 1);
double variableY = Math.Round((argumentk1 * variableX) + argumentb1, 1);
Console.WriteLine($"Координаты пересечения прямых равны: ({variableX:F1}; {variableY:F1})");

