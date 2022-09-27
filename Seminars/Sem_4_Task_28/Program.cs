/*
Задача 28: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N. 
4 -> 24
5 -> 120
*/
long GetMultOfRange(int startpoint, int endpoint)
{
    long result = 1;
    for (int i = startpoint; i <= endpoint; i++)
    {
        result *= i;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
long MultOfRange = GetMultOfRange(1, userNumber);
Console.WriteLine($"Произведение чисел от 1 до {userNumber} |по модулю| равняется {MultOfRange}!");
