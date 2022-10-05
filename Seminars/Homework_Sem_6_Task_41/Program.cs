/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}
void printArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}
Console.Write("Введите заданное количество чисел: ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());
int[] currentArray = generateArray((amountNumbers), -10, 10);
printArray(currentArray);
int result = 0;
for (int i = 0; i < currentArray.Length; i++)
{
    if (currentArray[i] > 0)
    {
        result = result + 1;
    }
}
Console.Write($"Количество чисел больше нуля равно: {result}");
