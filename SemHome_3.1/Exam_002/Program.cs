/*
Задача 18: Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

int getQuarterFromUser(string UserInformation)
{
    int quarter = new int();
    while (quarter == 0 | quarter > 4 | quarter < 1)
    {
        Console.Write(UserInformation);
        var userLine = Console.ReadLine();
        int.TryParse(userLine, out quarter);
        if (quarter == 0)
        {
            Console.WriteLine($"Input int number, your number is: {userLine}");
        }
        else if (quarter < 1 | quarter > 4)
        {
            Console.WriteLine($"Your quarter doesn't exist: {quarter}");
        }
    }
    return quarter;
}

void getDiapasonOfCoordination(int n)
{
    if (n == 1) System.Console.WriteLine($"Your quarter is: {n} and diapason coordinat: x > 0 and y > 0");
    else if (n == 2) System.Console.WriteLine($"Your quarter is: {n} and diapason coordinat: x < 0 and y > 0");
    else if (n == 3) System.Console.WriteLine($"Your quarter is: {n} and diapason coordinat: x < 0 and y < 0");
    else if (n == 4) System.Console.WriteLine($"Your quarter is: {n} and diapason coordinat: x > 0 and y < 0");
}

Console.Clear();
int userQuarter = getQuarterFromUser("Please enter a quarter: ");
getDiapasonOfCoordination(userQuarter);


