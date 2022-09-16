/*
0 Напишите программу, которая на вход принимает число и
выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Example_01");
Console.Write("Pleas enter your number: ");
int myint_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Pleas enter your stepen: ");
int stepen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your result is namber^stepen: {Math.Pow(myint_number, stepen)}");
