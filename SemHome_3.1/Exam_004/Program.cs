﻿/*
Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int getNumberFromUser(string UserInformation)
{
    int result = new int();
    while (result == 0)
    {
        Console.Write(UserInformation);
        var userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if (result == 0)
        {
            Console.WriteLine($"Enter int number: {userLine}");
        }
    }
    return result;
}

void squareTable(int number)
{
    int number_count = new int();
    if (number < 0)
    {
        number_count = number * -1;
    }
    else number_count = number;

    int count = 1;
    List<int> ListNumbers = new List<int>();
    while (count <= number_count)
    {
        if (number < 0)
        {
            int new_count = new int();
            new_count = count * -1;
            ListNumbers.Add((int)Math.Pow(new_count, 2));
        }
        else ListNumbers.Add((int)Math.Pow(count, 2));
        count += 1;
    }
    Console.WriteLine($"Your number is [{number}] -> {String.Join(", ", ListNumbers)}.");
}

Console.Clear();
int userNumber = getNumberFromUser("Please input a number: ");
squareTable(userNumber);
squareTable(2);
squareTable(5);
