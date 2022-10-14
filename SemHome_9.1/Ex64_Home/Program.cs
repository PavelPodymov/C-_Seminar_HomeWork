/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string NumberRange(int start, int end)
{
    if (start >= end) return $"{start}{((start == end)? "\"" : ',')} " + NumberRange(start - 1, end);
    else return String.Empty;
}

Console.Write("Input a number: ");
int n;
if (int.TryParse(Console.ReadLine(), out n) && n > 0)
{
    Console.WriteLine($"N = {n} -> \"{NumberRange(n, 1)}");
}
else Console.WriteLine($"Sorry you write wrong number");
