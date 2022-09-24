/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/


int getQuarterFromCoordinate(int CoordinateX, int CoordinateY)
{
    int result = 0;
    if (CoordinateX > 0 && CoordinateY > 0)
    {
        result = 1;
    }
    else if (CoordinateX < 0 && CoordinateY > 0)
    {
        result = 2;
    }
    else if (CoordinateX < 0 && CoordinateY < 0)
    {
        result = 3;
    }
    else if (CoordinateX > 0 && CoordinateY < 0)
    {
        result = 4;
    }
    return result;
}

int getCoordinateFromUser(string UserInformation)
{
    int result = new int();
    while (result == 0)
    {
        Console.Write(UserInformation);
        var userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0)
        {
            Console.WriteLine($"Input int number: {userLine}");
        }
    }
    return result;
}

Console.Clear();

int userCoordinateX = 0;
int userCoordinateY = 0;
// Console.Write("Please enter X: ");
// userCoordinateX = Convert.ToInt32(Console.ReadLine());
userCoordinateX = getCoordinateFromUser("Please enter X: ");

// Console.Write("Please enter Y: ");
// userCoordinateY = Convert.ToInt32(Console.ReadLine());
userCoordinateY = getCoordinateFromUser("Please enter Y: ");

int quarter = getQuarterFromCoordinate(userCoordinateX, userCoordinateY);
if (quarter != 0)
{
    Console.WriteLine($"Dot with coordinate [{userCoordinateX}; {userCoordinateY}], locate in {quarter} quarter");
}
else
{
    Console.WriteLine($"Your coodinate [{userCoordinateX}; {userCoordinateY}], and don't locate in exactly quarter");
}