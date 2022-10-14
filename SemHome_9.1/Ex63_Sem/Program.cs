/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

string NumberRange(int start, int end)
{
    if (start <= end) return $"{start}{((start == end)? "\"" : ',')} " + NumberRange(start + 1, end);
    else return String.Empty;
}

Console.Write("Input a number: ");
int n;
if (int.TryParse(Console.ReadLine(), out n) && n > 0)
{
    Console.WriteLine($"N = {n} -> \"{NumberRange(1, n)}");
}
else Console.WriteLine($"Sorry you write wrong number");

