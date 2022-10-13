/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задан спиральный массив 4 х 4 элемента:");
int n = 4;
int[,] generatedArray = new int[n, n];
int elementArray = 1;
int i = 0;
int j = 0;
while (elementArray <= generatedArray.GetLength(0) * generatedArray.GetLength(1))
{
  generatedArray[i, j] = elementArray;
  elementArray++;
  if (i <= j + 1 && i + j < generatedArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= generatedArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > generatedArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

print2DArray(generatedArray);
