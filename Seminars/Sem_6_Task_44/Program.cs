/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int FirstFibonacciNumbers(int userNumber)
{
    int numFib1 = 0;
    int numFib2 = 1;
    int numFib3 = 0;
    for (int i = 2; i < userNumber; i++)
    {
        numFib3 = numFib1 + numFib2;
        Console.Write($"{numFib3} ");
        numFib1 = numFib2;
        numFib2 = numFib3;
        if (i < userNumber - 1)
        {
            Console.Write(",");
        }
    }
    return numFib3;
}

int numFib1 = 0;
int numFib2 = 1;
Console.Write("Введите завершающий порядковый номер N для ряда Фибоначи: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Ряд Фибоначи от {numFib1} до {numberN} включает: {numFib1}, {numFib2}, ");
int RowFibonacciNumbers = FirstFibonacciNumbers(numberN);
