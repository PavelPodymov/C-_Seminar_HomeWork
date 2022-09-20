/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8
*/

int getRandomRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder+1);
    return result;
}

// for (int i = 0; i < 10; i++)
// {
//     int randNumber = getRandomRange(10, 99);
//     Console.WriteLine($"{i}. Random number is: {randNumber}");
// }
int getMaxFromNumber(int number)
{
    int maxDigit = new int();
    while (number > 0)
    {
        int currentDigit = number % 10;
        if (maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number /= 10;
    }
    return maxDigit;
}

int randNumber = getRandomRange(10, 99);
// Console.WriteLine($"Random number is: {randNumber}");
int maxDigit = getMaxFromNumber(randNumber);
Console.WriteLine($"Random number is: {randNumber}. Max number in random number is: {maxDigit}");


// int random_number = new Random().Next(10, 100);
// Console.WriteLine(random_number);
// // int rand_first_number = random_number / 10;
// // Console.WriteLine(rand_first_number);
// // int rand_second_number = random_number % 10;
// // Console.WriteLine(rand_second_number);
// // if (rand_first_number > rand_second_number)
// // {
// //     Console.WriteLine($"Maximum number in {random_number} is: {rand_first_number}");
// // }
// // else
// // {
// //     Console.WriteLine($"Maximum number in {random_number} is: {rand_second_number}");
// // }

// // OR

// if ((random_number / 10) > (random_number % 10))
// {
//     Console.WriteLine($"Maximum number in {random_number} is: {random_number / 10}");
// }
// else
// {
//     Console.WriteLine($"Maximum number in {random_number} is: {random_number % 10}");
// }