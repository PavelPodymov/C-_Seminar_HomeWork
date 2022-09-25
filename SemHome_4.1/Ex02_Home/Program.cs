/*
26. Возведите число А в натуральную степень B используя цикл
*/

int PowOfNumber(int num, int pow)
{
    int powerOfnum = num;
    for (int i = 2; i <= pow; i++)
    {
        powerOfnum *= num;
    }
    return powerOfnum;
}

int checkNumber(string UserString)
{
    int numb = new int();
    while (numb == 0)
    {
        Console.Write(UserString);
        var user_number = Console.ReadLine();
        int.TryParse(user_number, out numb);
    }
    return numb;
}

int checkPow(string UserString)
{
    int pow = new int();
    while (pow == 0)
    {
        Console.Write(UserString);
        var user_pow = Console.ReadLine();
        int.TryParse(user_pow, out pow);
    }
    return pow;
}

Console.Clear();
int number = checkNumber("Please input a number: ");
int pow = checkPow("Please input a Pow: ");
Console.WriteLine($"Number [{number}] in power [{pow}] = {PowOfNumber(number, pow)}");
