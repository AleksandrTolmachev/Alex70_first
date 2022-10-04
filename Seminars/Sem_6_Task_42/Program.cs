/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

// int value = 45;
// string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

Console.Write("Введите десятичное число: ");
int decimalNumber = int.Parse(Console.ReadLine());
int remainder;
string result = string.Empty;
while (decimalNumber > 0)
{
    remainder = decimalNumber % 2;
    decimalNumber /= 2;
    result = remainder.ToString() + result;
}
Console.WriteLine("Число в бинарном виде:  {0}", result);
