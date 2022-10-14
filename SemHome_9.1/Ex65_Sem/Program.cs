/*
Задача 65: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

string NumberRange(int start, int end)
{
    if (start <= end) return $"{start}{((start == end)? "\"" : ',')} " + NumberRange(start + 1, end);
    else return String.Empty;
}

Console.Write("Input a number start: ");
int start;
Int32.TryParse(Console.ReadLine(), out start);

Console.Write("Input a number End: ");
int end;
Int32.TryParse(Console.ReadLine(), out end);

if (end > 0 && start > 0)
{
    Console.WriteLine($"M = {start}; N = {end} -> \"{NumberRange(start, end)}");
}
else Console.WriteLine($"Sorry you write wrong number");