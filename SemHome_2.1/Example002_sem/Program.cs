/*
Напишите программу, которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

// Version with functions
Console.Clear();
int random_number(int first_num, int final_num)
{
    int ran_num = new int();
    ran_num = new Random().Next(first_num, final_num + 1);
    return ran_num;
}

int creat_new_number_without_second(int some_number)
{
    {
        int first_num = some_number / 100;
        int second_num = some_number % 100 % 10;
        int final_number = first_num * 10 + second_num;
        // or
        // string string_number = first_num.ToString() + second_num.ToString();
        // int final_number = int.Parse(string_number);
        return final_number;
    }
}

int number = random_number(100, 999);
Console.WriteLine($"Your random number is: {number}");

if (number > 100 & number < 1000)
{
    int num = creat_new_number_without_second(number);
    Console.WriteLine($"Your number is: {num}");
}
else
{
    Console.WriteLine($"Your random number is wrang, please try again");
}


// // Simple version
// int random_number = new Random().Next(100, 1000);
// Console.WriteLine(random_number);
// int rand_first_number = random_number / 100;
// string num1 = rand_first_number.ToString();
// int rand_third_number = random_number % 100 % 10;
// string num2 = rand_third_number.ToString();
// Console.WriteLine($"Your concatination number is: {num1+num2}");
