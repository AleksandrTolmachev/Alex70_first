/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

// int i, remain = 0, newNumber = 0;
// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32((Console.ReadLine()));
// for (i = number; i > 0; i = (i / 10))
// {
//     remain = i % 10;
//     newNumber = (newNumber * 10) + remain;
// }
// if (newNumber == number)
// {
//     Console.WriteLine($"Число {number} является палиндромом!", number);
// }
// else
// {
//     Console.WriteLine($"Число {number} не является палиндромом!");
// }
Console.Write("Введите желаемую длину массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте минимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MinMeaning = Convert.ToInt32(Console.ReadLine());
getPrint("Задайте максимальный диапазон значений в массиве: ", ConsoleColor.Blue);
int MaxMeaning = Convert.ToInt32(Console.ReadLine());
int[] arrayNorm = new int[userNumber];
for (int i = 0; i < userNumber; i++)
{
    arrayNorm[i] = new Random().Next(MinMeaning, MaxMeaning + 1);
}
// int[] arrayReversed = new int[userNumber];
// int remain = 0;
// arrayReversed[] = 0;
// for (i = 0; i < arrayNorm.length; i = (i / 10))
// {
//     remain = i % 10;
//     arrayReversed[i] = (arrayReversed * 10) + remain;;
// }
Console.Write($"Задан массив: ");
PrintArray(arrayNorm);
// PrintArray(arrayReversed);
// Console.WriteLine($". Сумма нечётных элементов массива равна {getSumOddArrayElements(sumOddArrayElements)}!");