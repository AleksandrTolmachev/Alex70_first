/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
Console.Write("Введите число элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write($"Массив из случайных {length} элементов: [");
for (int i = 0; i < length; i++)
    if (i < length - 1)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write($"{array[i]}, ");
    }
    else
    {
        array[i] = new Random().Next(1, 99);
        Console.Write($"{array[i]}");
    }
Console.Write("]");
