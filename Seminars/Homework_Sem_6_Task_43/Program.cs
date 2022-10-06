/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation}: ");
    }
    return result;
}
Console.WriteLine("Заданы две прямые, описываемые уравнениями: y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Ведите постоянные аргументы уравнений: ");
int argumentb1 = getCoordinateFromUser("b1 = ");
int argumentk1 = getCoordinateFromUser("k1 = ");
int argumentb2 = getCoordinateFromUser("b2 = ");
int argumentk2 = getCoordinateFromUser("k2 = ");

double findCoordinatesPointIntersectionLines(int argumentb1, int argumentk1, int argumentb2, int argumentk2)
{
    double variableX = Math.Sign(argumentb2 - argumentb1) / (argumentk1 - argumentk2);
    double variableY = Math.Sign(argumentk1 * variableX) + argumentb1;
    return Console.WriteLine($"{variableX:F1}, {variableY:F1}");
}
Console.WriteLine($"Координаты пересечения прямых равны: ({findCoordinatesPointIntersectionLines(argumentb1, argumentk1, argumentb2, argumentk2)})");
