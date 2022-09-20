/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
int getRandomNumber_100_999()
{
    int result = new Random().Next(100, 1000);
    return result;
}

void second_number(int some_num)
{
    int sec_num = some_num % 100 / 10;
    Console.WriteLine($"Your second number is {sec_num} from number {some_num}");
}

int random_num = getRandomNumber_100_999();
second_number(random_num);