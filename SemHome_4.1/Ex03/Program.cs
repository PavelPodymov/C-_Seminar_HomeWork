/*
27. Определить количество цифр в числе
*/



int quontity(string UserInformation)
{
    int num_count = new int();
    int cuonty_numbers = new int();
    int num = new int();
    while (num == 0)
    {
        Console.Write(UserInformation);
        var user_numb = Console.ReadLine();

        int.TryParse(user_numb, out num);

        if (num < 0) num_count = num * -1;
        else num_count = num;
        
        for (int i = 0; num_count > 0; i++)
        {
            num_count /= 10;
            cuonty_numbers += 1;
        }
    }
    return cuonty_numbers;
}

Console.Clear();
Console.WriteLine($"The quontity of numbers is {quontity("Please input a number: ")}");