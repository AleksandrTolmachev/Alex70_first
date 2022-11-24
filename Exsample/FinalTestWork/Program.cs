/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string[] getFormedAccordingConditionsArray(string[] incomingArray, string[] outgoingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if ((incomingArray[i].Length - 2) <= 3)
        {
            outgoingArray[count] = incomingArray[i];
            count++;
        }
    }
    return outgoingArray;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

// Пример 1:
// string[] originalArray = new string[] { "\"hello\"", "\"2\"", "\"world\"", "\":-)\"" };

// Пример 2:
string[] originalArray = new string[] { "\"1234\"", "\"1567\"", "\"-2\"", "\"computer science\"" };

// Пример 3:
// string[] originalArray = { "\"Russia\"", "\"Denmark\"", "\"Kazan\"" };

Console.WriteLine($"Исходный массив: ");
PrintArray(originalArray);

string[] formedArray = new string[originalArray.Length];
formedArray = getFormedAccordingConditionsArray(originalArray, formedArray);
Console.WriteLine($"Массив, сформированный с учётом условия: ");

int count = 0;
Console.Write("[");
for (int i = 0; i < formedArray.Length - 1; i++)
{
    Console.Write(formedArray[i]);
    count++;
    if ((formedArray.Length) - count <= 3)
    {
        Console.Write("");
    }
    if ((formedArray.Length) - count > 2)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
