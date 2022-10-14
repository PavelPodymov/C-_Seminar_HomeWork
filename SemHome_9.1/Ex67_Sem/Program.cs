/*
Задача 67: Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int SumNumericInNumbers(int number)
{
    if (number == 0) return 0;
    else return number % 10 + SumNumericInNumbers(number / 10);
}

Console.Write("Input a number: ");
int num;
Int32.TryParse(Console.ReadLine(), out num);

if (num > 0)
{
    Console.WriteLine($"{num} -> {SumNumericInNumbers(num)}");
}
else Console.WriteLine($"Sorry you write wrong number");