/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Power(int a, int b)
{   
    return b == 0 ? 1 : a * Power(a, b - 1);
}


Console.WriteLine(Power(2, 3));

Console.Write("Input a: ");
int a;
Int32.TryParse(Console.ReadLine(), out a);
Console.Write("Input b: ");
int b;
Int32.TryParse(Console.ReadLine(), out b);

if (a >= 0 && b >=0)
{
    Console.WriteLine($"A = {a}; B = {b} -> {Power(a, b)}");
}
else Console.WriteLine($"Sorry you write wrong number");