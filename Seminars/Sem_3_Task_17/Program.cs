/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/
int getQuarerFromCoordinate(int coordinateX, int coordinateY)
{
    int resalt = 0;
    if (coordinateX > 0 && coordinateY > 0)
    {
        resalt = 1;
    }
    else if (coordinateX < 0 && coordinateY > 0)
    {
        resalt = 2;
    }
    else if (coordinateX < 0 && coordinateY < 0)
    {
        resalt = 3;
    }
    else if (coordinateX > 0 && coordinateY < 0)
    {
        resalt = 4;
    }
    return resalt;
}
int getCoordinateFromUser(string userInformation)
{
    int resalt = 0;
    while (resalt == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out resalt);
        if (resalt == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число. Вы ввели {userLine}.");
        }
        else
        {
            break;
        }
    }
    return resalt;
}
int userCoordinateX = 0;
int userCoordinateY = 0;
Console.WriteLine("Введите координаты");
//Console.Write("X: ");
//userCoordinateX = Convert.ToInt32(Console.ReadLine());
userCoordinateX = getCoordinateFromUser("X: ");
//Console.Write("Y: ");
//userCoordinateY = Convert.ToInt32(Console.ReadLine());
userCoordinateY = getCoordinateFromUser("Y: ");

int quarter = getQuarerFromCoordinate(userCoordinateX, userCoordinateY);
if (quarter > 0)
{
    Console.WriteLine($"Точка с координатами [{userCoordinateX}:{userCoordinateY}] находится в {quarter} четверти.");
}
else
{
    Console.WriteLine($"Одна из координат является нулевой, нельзя понять, в какой четверти координаты [{userCoordinateX}:{userCoordinateY}].");
}
