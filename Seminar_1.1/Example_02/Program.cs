/*
1. Напишите программу, которая на вход принимает два числа 
и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.WriteLine("Example_02");
Console.Write("Pleas enter your square number: ");
int square_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Pleas enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (square_number/number == number)
{
    Console.WriteLine($"YES, the {number} is square number of {square_number}");
}
else
{
    Console.WriteLine($"NO, the {number} isn't a square number of {square_number}");
}