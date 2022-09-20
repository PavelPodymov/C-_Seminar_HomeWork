/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/
Console.Clear();
Console.Write($"Please enter your number: ");
string number = Console.ReadLine();
int num = int.Parse(number);

void div_7_23(int some_number)
{
    if (some_number % 7 == 0 & some_number % 23 == 0)
    {
        Console.WriteLine($"{some_number} -> Yes, divaid by 7 and 23");
    }
    else
    {
        Console.WriteLine($"{some_number} -> No, isn't divaid by 7 and 23");
    }
}

div_7_23(num);