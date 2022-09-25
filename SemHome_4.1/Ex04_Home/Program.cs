/*
28. Подсчитать сумму цифр в числе
*/

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

int sumOfNumericsInNumber(int numb)
{
    int sumOfNumeric = new int();
    if (numb < 0) numb *= -1;

    // for (int i = 0; numb > 0; i++)
    // {
    //     sumOfNumeric += numb % 10;
    //     numb /= 10;
    // }

    for (sumOfNumeric = 0; numb > 0; numb /= 10)
    {
        sumOfNumeric += numb % 10;
    }
    return sumOfNumeric;
}

Console.Clear();
int number = checkNumber("Please input a number: ");
Console.WriteLine($"The sum of numeric in numbers [{number}] is: {sumOfNumericsInNumber(number)}");
