/*
7. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
последнюю цифру этого числа
*/

Console.WriteLine("Example_09");

Console.Write("Pleas enter your number: ");
string number = Console.ReadLine();
int length_of_string = number.Length;
Console.WriteLine($"Your number is: {number[length_of_string-1]}");
