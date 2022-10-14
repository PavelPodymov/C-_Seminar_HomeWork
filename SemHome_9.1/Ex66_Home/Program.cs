/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbers(int start, int end )
{
    if (start > end) return 0;
    else return end + SumNumbers(start, end - 1);
}


Console.Write("Input a number start: ");
int start;
Int32.TryParse(Console.ReadLine(), out start);

Console.Write("Input a number End: ");
int end;
Int32.TryParse(Console.ReadLine(), out end);

if (end > 0 && start > 0)
{
    Console.WriteLine($"M = {start}; N = {end} -> {SumNumbers(start, end)}");
}
else Console.WriteLine($"Sorry you write wrong number");