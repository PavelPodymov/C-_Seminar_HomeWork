/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве. 
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
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

void pifagorRules(int ax, int ay, int bx, int by)
{
    double lenghtLine = Math.Round(Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2)), 2, MidpointRounding.ToZero);
    Console.WriteLine($"A ({ax}, {ay}); B ({bx}, {by}) -> Length: {lenghtLine}");
}

var userCoordinateAX = getCoordinateFromUser("Please enter A(X): ");
var userCoordinateAY = getCoordinateFromUser("Please enter A(Y): ");
var userCoordinateBX = getCoordinateFromUser("Please enter B(X): ");
var userCoordinateBY = getCoordinateFromUser("Please enter B(Y): ");
pifagorRules(userCoordinateAX, userCoordinateAY, userCoordinateBX, userCoordinateBY);
pifagorRules(3, 6, 2, 1);
pifagorRules(7, -5, 1, -1);
