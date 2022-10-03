/*
Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше
суммы двух других сторон.
*/

int checkTheNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
        if (numb < 0) numb = 0;
    }
    return numb;
}

void canTriangleExist(int x, int y, int z)
{
    if (x + y > z &&  z + y > x && x + z > y)
    {
        Console.WriteLine("YES, you can build the triangle");
    }
    else Console.WriteLine("Sorry, if you us your parameters, you can't build a triangle");
}

Console.Clear();
int numberX = checkTheNumber("Please input a X: ");
int numberY = checkTheNumber("Please input a Y: ");
int numberZ = checkTheNumber("Please input a Z: ");

canTriangleExist(numberX, numberY, numberZ);
