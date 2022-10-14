/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
Console.Write("Введите первое неотрицательное число m: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число n: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int functionAckermann = AckermannFunction(userNumberM, userNumberN);
Console.Write($"Функция Аккермана при m = {userNumberM} и n = {userNumberN} равна {functionAckermann}!");