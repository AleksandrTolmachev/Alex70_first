/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] generateMatrix(int height,int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height,width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i,j] = new Random().Next(randomStart, randomEnd+1 );
        }
    }
    return twoDArray;
}

void MultiplyMatrix(int[,] generatedMatrixA, int[,] generatedMatrixB, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < generatedMatrixA.GetLength(1); k++)
      {
        sum += generatedMatrixA[i,k] * generatedMatrixB[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void printMatrix(int[,] arrayToPrint)
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

Console.WriteLine("Задана матрица А:");
int[,] generatedMatrixA = generateMatrix(3,2,1,9);
printMatrix(generatedMatrixA);
Console.WriteLine("Задана матрица B:");
int[,] generatedMatrixB = generateMatrix(2,3,1,9);
printMatrix(generatedMatrixB);
int[,] resultMatrix = new int[3,3];
MultiplyMatrix(generatedMatrixA, generatedMatrixB, resultMatrix);
Console.WriteLine($"Произведение матриц А и В равно:");
printMatrix(resultMatrix);

