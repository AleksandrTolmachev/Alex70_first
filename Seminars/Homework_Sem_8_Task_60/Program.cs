/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] generate3DArray(int height, int width, int depth, int randomStart, int randomEnd)
{
    int[,,] threeDArray = new int[height, width, depth];
    int[,,] buf3DArray = new int[height, width, depth];
    int newElements = 0;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int z = 0; z < depth; z++)
            {
                while (buf3DArray[i, j, z] == threeDArray[i, j, z])
                {
                    buf3DArray[i, j, z] = new Random().Next(randomStart, randomEnd + 1);
                    newElements = buf3DArray[i, j, z];
                }
            }
        } 
    }
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int z = 0; z < depth; z++)
            {
                threeDArray[i, j, z] = buf3DArray[i, j, z];
            }
        }
    }
    return threeDArray;
}

void print3DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int z = 0; z < arrayToPrint.GetLength(2); z++)
            {
                Console.Write($"{arrayToPrint[i, j, z]}{(i, j, z)}   ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Задан трёхмерный массив из неповторяющихся чисел:");
int[,,] generatedArray = generate3DArray(2, 2, 2, 10, 99);
print3DArray(generatedArray);
