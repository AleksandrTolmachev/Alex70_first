/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

double RaisingNumberPower(double baseDegree, int exponent)
{
    if (exponent < 0)
    {
        Console.Error.WriteLine("Степень должна быть >= 0!");
        throw new Exception();
    }
    if (exponent == 0)
    {
        return 1;
    }
    if (exponent == 1)
    {
        return baseDegree;
    }
    return baseDegree * RaisingNumberPower(baseDegree, exponent - 1);
}

Console.Write("Введите число А - основание степени: ");
int baseDegree = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В - показатель степени: ");
int exponent = Convert.ToInt32(Console.ReadLine());

double result = RaisingNumberPower(baseDegree, exponent);
Console.Write($"Число {baseDegree} в степени {exponent} равняется: {result}!");