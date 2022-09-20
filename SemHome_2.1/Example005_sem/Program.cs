﻿/* 
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.Clear();
Console.Write("First number: ");
string first_number = Console.ReadLine();
int num1 = int.Parse(first_number);
Console.Write("Second number: ");
string second_number = Console.ReadLine();
int num2 = int.Parse(second_number);

void square_each_other(int some_num1, int some_num2)
{
    if (Math.Pow(some_num1, 2) == some_num2 | Math.Pow(some_num2, 2) == some_num1)
    {
        Console.WriteLine($"{some_num1}, {some_num2} -> YES, is square each other");
    }
    else Console.WriteLine($"{some_num1}, {some_num2} -> NO, isn't square each other");
}

square_each_other(num1, num2);