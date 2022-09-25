/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
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

string randomArray(int LenghtArray)
{
    List<int> myListInt = new List<int> ();
    for (int i = 1; i <= LenghtArray; i++)
    {
        int randomNumber = new Random().Next(0, 2);
        myListInt.Add(randomNumber);
    }
    return String.Join(", ", myListInt);
}

Console.Clear();

int numLenghtber = checkNumber("Please input a Length of array: ");
Console.WriteLine($"The lenght of array [{numLenghtber}] -> [{randomArray(numLenghtber)}]");
