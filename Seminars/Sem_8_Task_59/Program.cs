/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
*/
int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

int[,] FindPositionSmallElement(int[,] generatedArray, int[,] minPosition)
{
    int buffer = generatedArray[0, 0];
    for (int i = 0; i < generatedArray.GetLength(0); i++)
    {
        for (int j = 0; j < generatedArray.GetLength(1); j++)
        {
            if (generatedArray[i, j] <= buffer)
            {
                minPosition[0, 0] = i;
                minPosition[0, 1] = j;
                buffer = generatedArray[i, j];
            }
        }
    }
    Console.WriteLine($"Наименьший элемент массива: {buffer}!");
    return minPosition;
}

void DeleteLines(int[,] generatedArray, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < generatedArray.GetLength(0); i++)
  {
    for (int j = 0; j < generatedArray.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = generatedArray[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}

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
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Заданный массив:");
int[,] generatedArray = generate2DArray(4, 4, 1, 9);
print2DArray(generatedArray);
int[,] positionSmallElement = new int[3, 3];
positionSmallElement = FindPositionSmallElement(generatedArray, positionSmallElement);

int[,] arrayWithoutLines = new int[generatedArray.GetLength(0) - 1, generatedArray.GetLength(1) - 1];
DeleteLines(generatedArray, positionSmallElement, arrayWithoutLines);
Console.WriteLine("Массив, с удалением строк и столбцов наименьшего элемента:");
print2DArray(arrayWithoutLines);
