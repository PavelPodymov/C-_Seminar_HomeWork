/*
29. Написать программу вычисления произведения чисел от 1 до N
*/

int checkNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
        if (numb < 0) numb = 0;
    }
    return numb;
}

int multiplyOfNumbers(int num)
{
    int mult = 1;
    if (num < 0) mult = 1;
    else for (int i = 1; i <= num; i++) mult *= i;
    return mult;
}

Console.Clear();
int number = checkNumber("Please input a number N: ");
Console.WriteLine($"The result of multiply numbers between 1 to {number} = {multiplyOfNumbers(number)}");