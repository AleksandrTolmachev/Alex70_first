/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
int getSumOddArrayElements(int[] sumOddArrayElements)
{
    int sumOdd = 0;
    for (int i = 0; i <= (sumOddArrayElements.Length); i++)
    {
        if (i == 0 && i % 2 == 0)
        {
            i++;
        }
        if (i == 1 && i % 2 != 0)
        {
            sumOdd = sumOdd + sumOddArrayElements[i];
        }
        i++;
    }
    return sumOdd;
}

Console.Write("Введите желаемую длину массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте минимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MinMeaning = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте максимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MaxMeaning = Convert.ToInt32(Console.ReadLine());
int[] sumOddArrayElements = new int[userNumber];
for (int i = 0; i < userNumber; i++)
{
    sumOddArrayElements[i] = new Random().Next(MinMeaning, MaxMeaning + 1);
}
Console.Write($"Задан массив: ");
PrintArray(sumOddArrayElements);
Console.WriteLine($". Сумма нечётных элементов массива равна {getSumOddArrayElements(sumOddArrayElements)}!");