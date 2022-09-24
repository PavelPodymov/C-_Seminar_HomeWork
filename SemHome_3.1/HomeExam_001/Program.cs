/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int getNumberFromUser(string UserInformation)
{
    int Length_number = new int();
    int result = new int();
    while (result == 0 | Length_number != 5)
    {
        Console.Write(UserInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);

        int result_count = new int();
        if (result < 0)
        {
            result_count = result * -1;
            Length_number = result_count.ToString().Length;
        }
        else Length_number = result.ToString().Length;
      
        if (Length_number != 5 | result == 0)
        {
            Console.WriteLine($"Input int number you number is: {userLine}");
            Console.WriteLine($"Lenght_string: {Length_number}");
        }
        else break;
    }
    return result;
}

void Palindrom(int number)
{
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine($"Your number is: {number} -> YES palindrom");
    }
    else Console.WriteLine($"Your number is: {number} -> Sorry the number isn'i palindrom");
}


int numb = getNumberFromUser("Please input the number: ");

Palindrom(numb);
Palindrom(14212);
Palindrom(12821);
Palindrom(23432);
