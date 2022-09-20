/*
Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Clear();
Console.Write("First number: ");
string first_number = Console.ReadLine();
int num1 = int.Parse(first_number);
Console.Write("Second number: ");
string second_number = Console.ReadLine();
int num2 = int.Parse(second_number);

void div_number(int number1, int number2)
{
    if (number1 % number2 == 0) Console.WriteLine($"{number1} and {number2} -> кратно");
    else Console.WriteLine($"{number1} and {number2} -> не кратно, остаток {number1 % number2}");
}

div_number(num1, num2);