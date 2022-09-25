/*
30. Показать кубы чисел, заканчивающихся на четную цифру
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

void cubeWithlastEvenNumber(int num)
{   
    for (int i = 1; num >= i; i++)
    {
        if (num == 1) Console.WriteLine($"Your choice is [{num}] and you don't have any cub with last even number");
        else
        {
            int cub = (int)Math.Pow(i, 3);
            if (cub % 2 == 0) Console.WriteLine($"The number is {i} and cube with even last number is: {cub}");
        } 
    }
}

Console.Clear();
int number = checkNumber("Please input a number N: ");
cubeWithlastEvenNumber(number);