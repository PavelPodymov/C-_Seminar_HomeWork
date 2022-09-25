/*
25. Найти сумму чисел от 1 до А
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

int sumOfNumbers(int num)
{
    int sum = new int();
    if (num < 0) sum = 0;
    else for (int i = 1; i <= num; i++) sum += i;
    return sum;
}

Console.Clear();
int number = checkNumber("Please input a number A: ");
Console.WriteLine($"The result of sum numbers between 1 to {number} = {sumOfNumbers(number)}");
