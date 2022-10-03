/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите желаемую длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] diffMaxMinArray = new double[arrayLength];
Console.Write($"Задан вещественный массив: [");
Random random = new Random();
for (int i = 0; i < arrayLength; i++)
{
    diffMaxMinArray[i] = random.NextDouble() * 100;
    Console.Write($" {diffMaxMinArray[i]:F1}; ");
}
Console.Write($"]");
Console.WriteLine();

double maxNumber = diffMaxMinArray[1];
double minNumber = diffMaxMinArray[0];
if (diffMaxMinArray[1] > diffMaxMinArray[0])
{
    maxNumber = diffMaxMinArray[1];
    minNumber = diffMaxMinArray[0];
}
else
{
    maxNumber = diffMaxMinArray[0];
    minNumber = diffMaxMinArray[1];
}
if (diffMaxMinArray[2] > maxNumber)
{
    maxNumber = diffMaxMinArray[2];
}
if (diffMaxMinArray[2] < minNumber)
{
    minNumber = diffMaxMinArray[2];
}
if (diffMaxMinArray[3] > maxNumber)
{
    maxNumber = diffMaxMinArray[3];
}
if (diffMaxMinArray[3] < minNumber)
{
    minNumber = diffMaxMinArray[3];
}
if (diffMaxMinArray[4] > maxNumber)
{
    maxNumber = diffMaxMinArray[4];
}
if (diffMaxMinArray[4] < minNumber)
{
    minNumber = diffMaxMinArray[4];
}
double diffMaxMinNumber = maxNumber - minNumber;
Console.Write($"Разница между максимальным ({maxNumber:F1}) и минимальным ({minNumber:F1}) элементами массива равна: ({diffMaxMinNumber:F1}) ");
