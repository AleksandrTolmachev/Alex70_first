/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
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
void printArray(int[] arrayToPrint, string name)
{
    System.Console.WriteLine($"{name}");
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}
int[] copiedАrray(int[] inputArray)
{
    int[] copieArray = new int[inputArray.Length];
    for (int i = 0; i < inputArray.Length; i++)
    {
        copieArray[i] = inputArray[i];
    }
    return copieArray;
}

int[] currentArray = generateArray(15, 10, 99);
printArray(currentArray, "Заданный массив!");
int[] copiArray = copiedАrray(currentArray);
printArray(copiArray, "Поэлементно скопированный массив!");