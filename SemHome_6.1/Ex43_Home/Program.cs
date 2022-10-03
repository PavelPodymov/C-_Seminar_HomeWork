/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double checkNumber(string UserString, bool OnlyMarkPlus)
{
    int numb = new int();
    bool startCount = true;
    while (startCount)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();

        int.TryParse(user_number, out numb);

        if (numb <= 0 && OnlyMarkPlus == true) startCount = true;
        else
        {
            if (numb == 0 && user_number != "0") startCount = true;
            else startCount = false;
        }
    }
    return numb;
}

void dotOfCrossingTwoLines(double b1, double k1, double b2, double k2)
{
    Console.WriteLine();
    double y = 0;
    double x = 0;
    if (k1 == k2)
    {
        if (b1 != b2) Console.WriteLine($" k1=k2={k1} and b1={b1}, b2={b2}: Parallel lines. -> NO solutions");
        else Console.WriteLine($" k1=k2={k1} and b1={b1}=b2={b2}: Parallel lines. -> Infinity (@@) quantity of solutions");
    }
    else
    {
        x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
        y = k1 * x + b1;
        Console.WriteLine($" b1={b1}, k1={k1}, b2={b2}, k2={k1} -> ({x} ; {y})");
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("y = k1 * x + b1");
double B1 = checkNumber("coefficient b1: ", false);
double K1 = checkNumber("coefficient k1: ", false);
Console.WriteLine("y = k2 * x + b2");
double B2 = checkNumber("coefficient b2: ", false);
double K2 = checkNumber("coefficient k2: ", false);

dotOfCrossingTwoLines(B1, K1, B2, K2);
dotOfCrossingTwoLines(2, 5, 4, 9);