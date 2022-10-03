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
    Console.Write("{0,6:F1}; ", diffMaxMinArray[i]);
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

// for (int i = 0; i < arrayLength; i++)
// {
//     diffMaxMinArray[0] = diffMaxMinArray[i + 1];
//     if (diffMaxMinArray[i + 1] > maxNumber)
//     {
//         maxNumber = diffMaxMinArray[i + 1];
//     }
//     minNumber = diffMaxMinArray[i + 1];
// }
// return maxNumber;
// return minNumber;
// Console.WriteLine();
double diffMaxMinNumber = maxNumber - minNumber;
Console.Write($"Разница между максимальным и минимальным элементами массива равна: ");
Console.Write("{0,6:F1} ", diffMaxMinNumber);