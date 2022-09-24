/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

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
            Console.WriteLine($"Enter int number: {userLine}");
        }
    }
    return result;
}

void pifagorRules(int ax, int ay, int az, int bx, int by, int bz)
{
    double lenghtLine = Math.Round(Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2)), 2, MidpointRounding.ToZero);
    Console.WriteLine($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> Length: {lenghtLine}");
}


var userCoordinateAX = getCoordinateFromUser("Please enter A(X): ");
var userCoordinateAY = getCoordinateFromUser("Please enter A(Y): ");
var userCoordinateAZ = getCoordinateFromUser("Please enter A(Z): ");
var userCoordinateBX = getCoordinateFromUser("Please enter B(X): ");
var userCoordinateBY = getCoordinateFromUser("Please enter B(Y): ");
var userCoordinateBZ = getCoordinateFromUser("Please enter B(Z): ");
pifagorRules(userCoordinateAX, userCoordinateAY, userCoordinateAZ, userCoordinateBX, userCoordinateBY, userCoordinateBZ);
pifagorRules(3, 6, 8, 2, 1, -7);
pifagorRules(7, -5, 0, 1, -1, 9);