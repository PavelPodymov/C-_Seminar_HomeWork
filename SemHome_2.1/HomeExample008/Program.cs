/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Please enter the number of day: ");
string number_of_day = Console.ReadLine();
int num = int.Parse(number_of_day);

List<string> days = new List<string>() { "Monday", "Tuesday", "Wednesday", 
"Thursday", "Friday", "Saturday", "Sunday" };

void weekend_or_not(int some_number)
{
    if (1 > some_number | some_number > 7) Console.WriteLine($"Your number is {some_number}, it's wrang number");
    else
    {
        if (some_number == 6 | some_number == 7)
        {
            Console.WriteLine("YES, YES, YES -> WEEKEND");
            Console.WriteLine($"The your choice is {some_number}, it's {days[some_number-1]} -> YES, WEEKEND");
        }
        else
        {
            Console.WriteLine("NO, NO, NO -> WEEKEND");
            Console.WriteLine($"The your choice is {some_number}, it's {days[some_number-1]} -> NO, WEEKEND");
        }
    }
}

weekend_or_not(num);