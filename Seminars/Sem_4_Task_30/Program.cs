/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке. 
[1,0,1,1,0,1,0,0]
*/
Console.Write("Введите число элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Console.Write($"Массив из {length} элементов: ");
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]}, ");
}


//Console.Write($" Массив из 8 элементов: [{array}, ]");
