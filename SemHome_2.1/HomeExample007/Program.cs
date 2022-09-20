/*
Задача 13: Напишите программу, которая выводит третью
цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
int getRandomNumber()
{
    int result = new Random().Next();
    return result;
}

void find_third_number(int some_number)
{
    if (some_number < 99) Console.WriteLine($"There is no third number in: {some_number}");
    else
    {
        while (some_number > 999)
        {
            some_number /= 10;
        }
        Console.WriteLine($"The third number from left is: {some_number % 10}");
    }
}

int random_num = getRandomNumber();
Console.WriteLine($"The random number is: {random_num}");
find_third_number(random_num);
Console.WriteLine("Other numbers isn't a random: ");
find_third_number(645);
find_third_number(78);
find_third_number(32679);