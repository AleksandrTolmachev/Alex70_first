/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
void getPrint(string Text, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(Text);
    Console.ResetColor();
}
int getSumEvenNumbers(int[] sumEvenArray)
{
    int result = 0;
    for (int i = 0; i < sumEvenArray.Length; i++)
    {
        if (sumEvenArray[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

Console.Write("Введите желаемую длину массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте минимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MinMeaning = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте максимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MaxMeaning = Convert.ToInt32(Console.ReadLine());
int[] sumEvenArray = new int[userNumber];
for (int i = 0; i < userNumber; i++)
{
    sumEvenArray[i] = new Random().Next(MinMeaning, MaxMeaning + 1);
}
Console.Write($"Задан массив: ");
PrintArray(sumEvenArray);
Console.WriteLine($". Количество чётных чисел в массиве равно {getSumEvenNumbers(sumEvenArray)}!");