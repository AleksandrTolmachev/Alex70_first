/*
Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
    System.Console.WriteLine($"-------------------{name}-------------------");
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
int[] multiplyOfBorderElementsOfArray(int[] inputArray)
{
    int lengthOfNewArray = (int)Math.Ceiling(inputArray.Length / 2.0);
    Console.WriteLine($"Для количества {inputArray.Length} в новый массив {lengthOfNewArray}");
    int[] result = new int[lengthOfNewArray];
    for (int i = 0; i < lengthOfNewArray; i++)
    {
        if (i != inputArray.Length - i - 1)
        {
            result[i] = inputArray[i] * inputArray[inputArray.Length - i - 1];
        }
        else
        {
            result[i] = inputArray[i];
        }
    }
    return result;
}
int[] currentArray = generateArray(9, 1, 10);
printArray(currentArray, "Исходный");
int[] multiplyArray = multiplyOfBorderElementsOfArray(currentArray);
printArray(multiplyArray, "Результат");